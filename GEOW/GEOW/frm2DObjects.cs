using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GEOWObj;
using GEOWObj.contracts;

using GEOWNeg;

using GEOWData;

namespace GEOW
{
    public partial class frm2DObjects : Form
    {
        Random _rnd = new Random();
        Graphics _Hoja;

        private infoObjects INFO = new infoObjects();
        private List<PointObj> OBJETOS = new List<PointObj>();
        private List<PointObj> ObjetosGrabados;
        private Actions ActionRecord;

        private static IRecording RecordingDataObj = new data_Recording();
        private static IJourney JourneyDataObj = new data_Journey();

        private INeg_BufferPositions _negobjectbuffer = new Neg_BufferPositions(1000, RecordingDataObj);
        private INeg_Journey _negjourney = new Neg_Journey(JourneyDataObj);

        private Color SelectedColor = Color.Black;

        private bool Grabando = false;
        private Int64 _IdJourney = 0;

        public frm2DObjects()
        {
            InitializeComponent();
        }

        private void frm2DObjects_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            _Hoja = picOut.CreateGraphics();

            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(lstInfo, true, null);

            LoadScenario(scenario.scenario_base.enumEscenarios.scenario_2_tamanhosdistintos_total_5xNum);

            timerObjetos.Enabled = true;
        }

        private void frm2DObjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Desactiva();
            timerTransferPositions.Enabled = false;

            FinalizaGrabacionPosiciones();
            TransferPositionsToReadModel();
        }


        //-->>
        #region Eventos del formularios

        private void trackBarVelocidad_Scroll(object sender, EventArgs e)
        {
            timerAnimacion.Interval = trackBarVelocidad.Value;
        }

        private void lstInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInfo.SelectedItems.Count == 1)
            {
                foreach (ListViewItem lstIt in lstInfo.Items)
                {
                    lstIt.ForeColor = Color.Black;
                }

                INFO.ObjetoSeleccionado = (PointObj)lstInfo.SelectedItems[0].Tag;
                lstInfo.SelectedItems[0].ForeColor = Color.Red;

                lstInfo.SelectedIndices.Clear();

                panelControlDireccion.Visible = true;
            }

            cmdArriba.Focus();
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                Activa();
            }
            else
            {
                Desactiva();
            }

            if (Grabando)
            {
                ActionRecord.CambioActivacion();
            }
        }

        private void chkTraza_CheckedChanged(object sender, EventArgs e)
        {
            if (Grabando)
            {
                ActionRecord.CambioTraza();
            }
        }

        private void chkCambios_CheckedChanged(object sender, EventArgs e)
        {
            if (Grabando)
            {
                ActionRecord.CambioPosicion();
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            picOut.Visible = chkVisible.Checked;
        }

        private void frm2DObjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (panelControlDireccion.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:

                        Parriba();
                        e.Handled = true;
                        break;

                    case Keys.Down:

                        Pabajo();
                        e.Handled = true;
                        break;

                    case Keys.Right:

                        PaLaDerecha();
                        e.Handled = true;
                        break;

                    case Keys.Left:

                        PaLaIzquierda();
                        e.Handled = true;
                        break;
                }
            }
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = false;
            MyDialog.Color = Color.Black;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = MyDialog.Color;
                txtColor.Text = SelectedColor.Name;
            }
        }

        private void picClosePanel_Click(object sender, EventArgs e)
        {
            panelControlDireccion.Visible = false;
        }

        #endregion


        //-->>
        #region Acciones - Botones

        private void cmdAddObject_Click(object sender, EventArgs e)
        {
            try
            {
                int xinicial = int.Parse(txtXInicial.Text);
                int yinicial = int.Parse(txtYInicial.Text);

                int alto = int.Parse(txtAlto.Text);
                int ancho = int.Parse(txtAncho.Text);

                int cantidad = int.Parse(txtCantidad.Text);

                PointObj.enumDireccion _direccion = PointObj.enumDireccion.Derecha;

                switch (cmbDireccion.Text)
                {
                    case "Arriba":

                        _direccion = PointObj.enumDireccion.Arriba;
                        break;

                    case "Abajo":

                        _direccion = PointObj.enumDireccion.Abajo;
                        break;

                    case "Izquierda":

                        _direccion = PointObj.enumDireccion.Izquierda;
                        break;

                    case "Derecha":

                        _direccion = PointObj.enumDireccion.Derecha;
                        break;
                }

                List<PointObj> newobjects = new List<PointObj>();

                int numobjects = OBJETOS.Count;

                string nombre = "";
                string nombrebase = ""; 

                if (txtNombre.Text.Trim().Length > 0)
                {
                    nombrebase = txtNombre.Text.Trim().ToLower();
                }
                else
                {
                    nombrebase = "RunTimeObj";
                }
                
                for (int cont = 0; cont < cantidad; cont++)
                {
                    nombre = nombrebase + "_" + (OBJETOS.Count + cont + 1).ToString();

                    PointObj _point = new PointObj(SelectedColor,
                                                xinicial, yinicial,
                                                alto, ancho,
                                                _direccion,
                                                picOut.Width, picOut.Height,
                                                nombre, _negobjectbuffer);

                    newobjects.Add(_point);
                }

                OBJETOS.AddRange(newobjects);

                SetIdJourney();

                //Graba la acción
                if (Grabando)
                {
                    ActionRecord.AgregaObjetos(OBJETOS.Except(ObjetosGrabados).ToList());
                    ObjetosGrabados = new List<PointObj>(OBJETOS);
                }
            }
            catch
            {

            }
        }

        private void cmdClean_Click(object sender, EventArgs e)
        {
            FinalizaGrabacionPosiciones();

            OBJETOS.Clear();
            _Hoja.Clear(Color.White);
        }

        private void cmdEscenarios_Click(object sender, EventArgs e)
        {
            subforms.frmGetEscenario _frmEscenarios = new subforms.frmGetEscenario(this, _negobjectbuffer);
            _frmEscenarios.ShowDialog();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (Grabando)
            {
                cmdGrabar.Text = "Inicia grabación";
                Grabando = false;
                lblGrabando.Visible = false;

                //Finaliza la grabación
                Task _recordactions = new Task(() => ActionRecord.RecordActions());
                _recordactions.Start();
            }
            else
            {
                cmdGrabar.Text = "Finaliza grabación";
                Grabando = true;
                lblGrabando.Visible = true;

                //Inica la grabación de acciones. Paso 1: captura de la situación inicial
                ActionRecord = new Actions(OBJETOS, chkTraza.Checked, chkCambios.Checked, chkActivo.Checked,
                                           new Neg_Actions(RecordingDataObj));

                ObjetosGrabados = new List<PointObj>(OBJETOS);
            }
        }

        private void cmdConsultas_Click(object sender, EventArgs e)
        {
            frmReport2DObjects _frm = new frmReport2DObjects();
            _frm.Show();
        }

        #endregion


        //-->>
        #region Métodos publicados invocados desde otros contenedores

        public void LoadScenario(scenario.scenario_base.enumEscenarios Escenario)
        {
            scenario.scenario_base sc;

            switch (Escenario)
            {
                case scenario.scenario_base.enumEscenarios.scenario_1_tamanhosiguales_total_5xNum:

                    sc = new scenario.scenario_1_tamanhosiguales_total_5xNum(picOut.Height, picOut.Width, 0, _negobjectbuffer);
                    OBJETOS.AddRange(sc.Get(33));
                    break;

                case scenario.scenario_base.enumEscenarios.scenario_2_tamanhosdistintos_total_5xNum:

                    sc = new scenario.scenario_2_tamanhosdistintos_total_5xNum(picOut.Height, picOut.Width, 0, _negobjectbuffer);
                    OBJETOS.AddRange(sc.Get(33));
                    break;

                case scenario.scenario_base.enumEscenarios.scenario_3_persecucion:

                    sc = new scenario.scenario_3_persecucion(picOut.Height, picOut.Width, 0, _negobjectbuffer);
                    OBJETOS.AddRange(sc.Get());
                    break;

            };

            SetIdJourney();

            INFO.numElementos = OBJETOS.Count;
        }

        #endregion


        //-->>
        #region Métodos privados

        private void PintaCoordenadas(string nombre, int X, int Y)
        {
            var LstIt = lstInfo.FindItemWithText(nombre);

            if (LstIt != null)
            {
                LstIt.SubItems[1].Text = X.ToString();
                LstIt.SubItems[2].Text = Y.ToString();
            }
        }

        private void IniciaGrabacionPosiciones()
        {
            _IdJourney = _negjourney.New();

            SetIdJourney();
        }

        private void FinalizaGrabacionPosiciones()
        {
            _negobjectbuffer.Flush();
        }

        private void TransferPositionsToReadModel()
        {
            _negobjectbuffer.TransferPositionsToReadModel();
        }

        private void Activa()
        {
            IniciaGrabacionPosiciones();

            timerAnimacion.Interval = trackBarVelocidad.Value;
            timerAnimacion.Enabled = true;
            timerCambiosDireccion.Enabled = true;

            Thread.Sleep(100);
            Application.DoEvents();
        }

        private void Desactiva()
        {
            timerAnimacion.Enabled = false;

            FinalizaGrabacionPosiciones();
        }

        private void SetIdJourney()
        {
            foreach (PointObj _point in OBJETOS)
            {
                _point.SetIdJourney(_IdJourney);
            }
        }

        #endregion


        //-->>
        #region Private PA Functions

        private void Parriba()
        {
            if (INFO.ObjetoSeleccionado != null)
            {
                if (INFO.ObjetoSeleccionado.EsLider)
                {
                    INFO.ObjetoSeleccionado.Followers = OBJETOS.Where(ob => ob.EsPerseguidor).ToList();
                }

                INFO.ObjetoSeleccionado.Direccion = PointObj.enumDireccion.Arriba;
            }
        }

        private void Pabajo()
        {
            if (INFO.ObjetoSeleccionado != null)
            {
                if (INFO.ObjetoSeleccionado.EsLider)
                {
                    INFO.ObjetoSeleccionado.Followers = OBJETOS.Where(ob => ob.EsPerseguidor).ToList();
                }

                INFO.ObjetoSeleccionado.Direccion = PointObj.enumDireccion.Abajo;
            }
        }

        private void PaLaDerecha()
        {
            if (INFO.ObjetoSeleccionado != null)
            {
                if (INFO.ObjetoSeleccionado.EsLider)
                {
                    INFO.ObjetoSeleccionado.Followers = OBJETOS.Where(ob => ob.EsPerseguidor).ToList();
                }

                INFO.ObjetoSeleccionado.Direccion = PointObj.enumDireccion.Derecha;
            }
        }

        private void PaLaIzquierda()
        {
            if (INFO.ObjetoSeleccionado != null)
            {
                if (INFO.ObjetoSeleccionado.EsLider)
                {
                    INFO.ObjetoSeleccionado.Followers = OBJETOS.Where(ob => ob.EsPerseguidor).ToList();
                }

                INFO.ObjetoSeleccionado.Direccion = PointObj.enumDireccion.Izquierda;
            }
        }

        #endregion


        //-->>
        #region Botones de dirección

        private void cmdArriba_Click(object sender, EventArgs e)
        {
            Parriba();
        }

        private void cmdAbajo_Click(object sender, EventArgs e)
        {
            Pabajo();
        }

        private void cmdIzquierda_Click(object sender, EventArgs e)
        {
            PaLaIzquierda();
        }

        private void cmdDerecha_Click(object sender, EventArgs e)
        {
            PaLaDerecha();
        }

        #endregion


        //-->>
        #region Timers

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (!chkTraza.Checked)
            {
                _Hoja.Clear(Color.White);
            }

            foreach (PointObj _obj in OBJETOS)
            {
                if (picOut.Visible)
                {
                    _Hoja.DrawRectangle(_obj.PenObj, _obj.X, _obj.Y, _obj.Ancho, _obj.Alto);
                }

                PintaCoordenadas(_obj.NombreObjeto, _obj.X, _obj.Y);

                _obj.Muevelo();
            }
        }

        private void timerObjetos_Tick(object sender, EventArgs e)
        {
            if (OBJETOS.Count != lstInfo.Items.Count)
            {
                lstInfo.Items.Clear();

                foreach (PointObj _obj in OBJETOS)
                {
                    ListViewItem lstIt = new ListViewItem(_obj.NombreObjeto);
                    lstIt.Tag = _obj;

                    lstIt.SubItems.Add(_obj.X.ToString());
                    lstIt.SubItems.Add(_obj.Y.ToString());

                    lstInfo.Items.Add(lstIt);
                }

                lblTotalObjetos.Text = OBJETOS.Count.ToString();

                lstInfo.SelectedIndices.Clear();
            }           
        }

        private void timerCambios_Tick(object sender, EventArgs e)
        {
            if (chkCambios.Checked)
            {
                foreach (PointObj _obj in OBJETOS.Where(ob => ob.EsLider == false && ob.EsPerseguidor == false))
                {
                    int aleatorio = _rnd.Next(0, 100);

                    if (aleatorio < 10 && _obj.Direccion != PointObj.enumDireccion.Abajo)
                    {
                        _obj.Direccion = PointObj.enumDireccion.Arriba;
                    }
                    else if (aleatorio < 20 && _obj.Direccion != PointObj.enumDireccion.Arriba)
                    {
                        _obj.Direccion = PointObj.enumDireccion.Abajo;
                    }
                    else if (aleatorio < 30 && _obj.Direccion != PointObj.enumDireccion.Derecha)
                    {
                        _obj.Direccion = PointObj.enumDireccion.Izquierda;
                    }
                    else if (aleatorio < 40 && _obj.Direccion != PointObj.enumDireccion.Izquierda)
                    {
                        _obj.Direccion = PointObj.enumDireccion.Derecha;
                    }

                }
            }
        }

        private void timerTransferPositions_Tick(object sender, EventArgs e)
        {
            TransferPositionsToReadModel();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GEOWObj.DTO;
using GEOWObj.contracts;

using GEOWNeg;

using GEOWData;

namespace GEOW
{
    public partial class frmReport2DObjects : Form
    {
        private IReading _obj_dataQ;
        private INeg_Quering _obj_negQ;

        private List<GetJourneysDTO> JourneysActual;
        private List<GetJourneyObjectsDTO> ObjectsActual;
        private GetJourneysDTO SelectedJourney;

        public frmReport2DObjects()
        {
            InitializeComponent();

            _obj_dataQ = new data_Reading();
            _obj_negQ = new Neg_Quering(_obj_dataQ);
        }

        private void frmReport2DObjects_Load(object sender, EventArgs e)
        {
            System.Reflection.PropertyInfo propiedadListView = typeof(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            propiedadListView.SetValue(lstTrayectos, true, null);
            propiedadListView.SetValue(lstObjetos, true, null);

            GetTrayectos();

            timerTrayectos.Enabled = true;
        }

        private void lstTrayectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTrayectos.SelectedItems.Count == 1)
            {
                foreach (ListViewItem lstIt in lstTrayectos.Items)
                {
                    lstIt.ForeColor = Color.Black;
                }

                SelectedJourney = (GetJourneysDTO)lstTrayectos.SelectedItems[0].Tag;
                lstTrayectos.SelectedItems[0].ForeColor = Color.Red;

                GetObjetos(SelectedJourney.idJourney);

                lstTrayectos.SelectedIndices.Clear();
            }
        }

        private void GetTrayectos()
        {
            //Lista actualizada de trayectos
            List<GetJourneysDTO> _journeys = _obj_negQ.GetJourneys();

            bool HayCambiosEnTrayectos = false;
            bool nuevostrayectos = JourneysActual != null && _journeys.Count != JourneysActual.Count;

            //Si hay nuevos trayectos cargamos de nuevo la lista de trayectos
            if (nuevostrayectos)
            {
                HayCambiosEnTrayectos = true;
                MuestraTrayectos(_journeys);
            }
            else
            {
                if (JourneysActual != null && !(_journeys.SequenceEqual(JourneysActual)))
                {
                    HayCambiosEnTrayectos = true;

                    //Hay cambios en la secuencia de trayectos.
                    //Hay que comprobar qué cambios

                    //Para cambios solo de coordenadas, buscamos el cambio y recargamos solo ese dato
                    List<GetJourneysDTO> _journeyconcambiodecoordenadas = (from jact in _journeys
                                                                           join jant in JourneysActual on jact.idJourney equals jant.idJourney
                                                                           where jact.numCoordenadasTotal != jant.numCoordenadasTotal
                                                                           select jact).ToList();

                    if (_journeyconcambiodecoordenadas.Count > 0)
                    {
                        foreach (GetJourneysDTO _j in _journeyconcambiodecoordenadas)
                        {
                            var LstIt = lstTrayectos.FindItemWithText(_j.dtInicio.ToShortDateString() + " " + _j.dtInicio.ToLongTimeString());

                            if (LstIt != null)
                            {
                                LstIt.SubItems[2].Text = _j.numCoordenadasTotal.ToString();
                            }
                        }
                    }

                    //Si además hay cambios en el número de objetos debemos recargar el dato

                    //Pero además debemos comprobar si el cambio de num. de objetos se encuentra en el elemento seleccionado
                    //Si es así hay que recargar la lista de objetos

                    List<GetJourneysDTO> _journeyconcambiodeobjetos = (from jact in _journeys
                                                                       join jant in JourneysActual on jact.idJourney equals jant.idJourney
                                                                       where jact.numObjetos != jant.numObjetos
                                                                       select jact).ToList();

                    if (_journeyconcambiodeobjetos.Count > 0)
                    {
                        bool cambioenelementoseleccionado = false;

                        foreach (GetJourneysDTO _j2 in _journeyconcambiodeobjetos)
                        {
                            var LstIt = lstTrayectos.FindItemWithText(_j2.dtInicio.ToShortDateString() + " " + _j2.dtInicio.ToLongTimeString());

                            if (LstIt != null)
                            {
                                LstIt.SubItems[1].Text = _j2.numObjetos.ToString();
                            }

                            if (SelectedJourney != null && _j2.idJourney == SelectedJourney.idJourney)
                            {
                                cambioenelementoseleccionado = true;
                            }
                        }

                        if (cambioenelementoseleccionado) { GetObjetos(SelectedJourney.idJourney); }
                    }
                }
                else if (JourneysActual == null)
                {
                    //Primera carga - solo carga los trayectos
                    HayCambiosEnTrayectos = true;
                    MuestraTrayectos(_journeys);
                }
                else
                {
                    //No hay cambios
                    HayCambiosEnTrayectos = false;
                }
            }

            //Finalmente dejamos reflejados los cambios
            if (HayCambiosEnTrayectos) { JourneysActual = new List<GetJourneysDTO>(_journeys); }


            //------------------------------------------------------------------------------
            //------------------------------------------------------------------------------
            //------------------------------------------------------------------------------
            //if (JourneysActual == null || !(_journeys.SequenceEqual(JourneysActual)))
            //{
            //    if (!nuevostrayectos && (SelectedJourney != null && SelectedJourney.numObjetos == _obj_negQ.GetJourneyObjects(SelectedJourney.idJourney).Count()))
            //    {
            //        //solo actualiza las coordenadas
            //        var LstIt = lstTrayectos.FindItemWithText(SelectedJourney.dtInicio.ToShortDateString() + " " + SelectedJourney.dtInicio.ToLongTimeString());

            //        if (LstIt != null)
            //        {
            //            LstIt.SubItems[2].Text = _journeys.Where(j => j.idJourney == SelectedJourney.idJourney).First().numCoordenadasTotal.ToString();
            //        }
            //    }
            //    else
            //    {
            //        MuestraTrayectos(_journeys);

            //        if (SelectedJourney != null && SelectedJourney.numObjetos != ObjectsActual.Count)
            //        {
            //            GetObjetos(SelectedJourney.idJourney);
            //        }
            //    }
            //}

        }

        private void MuestraTrayectos(List<GetJourneysDTO> _journeys)
        {
            //actualiza la tabla completa
            lstTrayectos.Items.Clear();
            lblTrayectos.Text = "Trayectos (" + _journeys.Count.ToString() + ")";

            foreach (GetJourneysDTO _journey in _journeys)
            {
                ListViewItem lstIt = new ListViewItem(_journey.dtInicio.ToShortDateString() + " " + _journey.dtInicio.ToLongTimeString());
                lstIt.SubItems.Add(_journey.numObjetos.ToString());
                lstIt.SubItems.Add(_journey.numCoordenadasTotal.ToString());

                lstIt.Tag = _journey;

                if (SelectedJourney != null && _journey.idJourney == SelectedJourney.idJourney)
                {
                    lstIt.ForeColor = Color.Red;
                }

                lstTrayectos.Items.Add(lstIt);
            }
        }

        private void GetObjetos(Int64 idTrayecto)
        {
            var _objects = _obj_negQ.GetJourneyObjects(idTrayecto);

            if (ObjectsActual == null || !_objects.SequenceEqual(ObjectsActual))
            {
                ObjectsActual = new List<GetJourneyObjectsDTO>(_objects);

                lstObjetos.Items.Clear();
                lblObjetos.Text = "Objetos (" + _objects.Count.ToString() + ")";

                foreach (GetJourneyObjectsDTO _object in _objects)
                {
                    ListViewItem lstIt = new ListViewItem(_object.OBJDesc);
                    lstIt.SubItems.Add(_object.Color);
                    lstIt.SubItems.Add(_object.Alto.ToString());
                    lstIt.SubItems.Add(_object.Ancho.ToString());
                    lstIt.SubItems.Add("");

                    lstIt.Tag = _object;

                    lstObjetos.Items.Add(lstIt);
                }
            }
        }

        private void timerTrayectos_Tick(object sender, EventArgs e)
        {
            GetTrayectos();
        }

        private void timerObjetos_Tick(object sender, EventArgs e)
        {
            if (SelectedJourney != null)
            {
                GetObjetos(SelectedJourney.idJourney);
            }
        }
    }
}

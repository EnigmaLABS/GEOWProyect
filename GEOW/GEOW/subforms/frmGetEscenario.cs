using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GEOWObj.contracts;

namespace GEOW.subforms
{
    public partial class frmGetEscenario : Form
    {
        private frm2DObjects _container;
        private INeg_BufferPositions _negobj;
        private INeg_UDPClient _negudpobj;

        public frmGetEscenario(frm2DObjects p_container, INeg_BufferPositions p_negobj, INeg_UDPClient p_negudpobj)
        {
            InitializeComponent();

            _container = p_container;
            _negobj = p_negobj;
            _negudpobj = p_negudpobj;
        }

        private void frmGetEscenario_Load(object sender, EventArgs e)
        {
            scenario.scenario_base _sb = new scenario.scenario_base(0, 0, 0, _negobj, _negudpobj);

            foreach (string esc in _sb.getEscenas())
            {
                chkEscernarios.Items.Add(esc);
            }
        }

        private void picLoadEscenario_Click(object sender, EventArgs e)
        {
            if (chkEscernarios.CheckedItems.Count == 1)
            {
                string esc = chkEscernarios.CheckedItems[0].ToString();

                switch (esc)
                {
                    case "scenario_1_tamanhosiguales_total_5xNum":

                        _container.LoadScenario(scenario.scenario_base.enumEscenarios.scenario_1_tamanhosiguales_total_5xNum);
                        break;

                    case "scenario_2_tamanhosdistintos_total_5xNum":

                        _container.LoadScenario(scenario.scenario_base.enumEscenarios.scenario_2_tamanhosdistintos_total_5xNum);
                        break;

                    case "scenario_3_persecucion":

                        _container.LoadScenario(scenario.scenario_base.enumEscenarios.scenario_3_persecucion);
                        break;

                }

                this.Close();
            }
        }
    }
}

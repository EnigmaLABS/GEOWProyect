using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOW.scenario
{
    public class scenario_base
    {
        public enum enumEscenarios { scenario_1_tamanhosiguales_total_5xNum, scenario_2_tamanhosdistintos_total_5xNum , scenario_3_persecucion }
        public enumEscenarios EscenarioActual;

        public int altoLienzo;
        public int anchoLienzo;
        public int elementos_existentes;

        public INeg_BufferPositions _negobj;
        public INeg_UDPClient _negudpobj;

        public scenario_base(int p_altoLienzo, int p_anchoLienzo, int p_elementos_existentes, INeg_BufferPositions p_negobj, INeg_UDPClient p_negudpobj)
        {
            altoLienzo = p_altoLienzo;
            anchoLienzo = p_anchoLienzo;
            elementos_existentes = p_elementos_existentes;

            _negobj = p_negobj;
            _negudpobj = p_negudpobj;
        }

        public List<string> getEscenas()
        {
            List<string> _escenas = new List<string>() { "scenario_1_tamanhosiguales_total_5xNum",
                                                         "scenario_2_tamanhosdistintos_total_5xNum",
                                                         "scenario_3_persecucion"
            };

            return _escenas;
        }

        public virtual List<PointObj> Get(int num)
        {
            return new List<PointObj>();
        }

        public virtual List<PointObj> Get()
        {
            return new List<PointObj>();
        }
    }
}

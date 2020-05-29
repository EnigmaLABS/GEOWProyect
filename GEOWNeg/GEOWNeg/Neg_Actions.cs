using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOWNeg
{
    public class Neg_Actions : GEOWObj.contracts.INeg_Actions
    {
        private IRecording _recordingObj;

        public Neg_Actions(IRecording p_recordingObj)
        {
            _recordingObj = p_recordingObj;
        }

        public void RecordActions(List<Actions> lstActions)
        {
            try
            {
                if (lstActions.Count(ac => ac.TipoAccion != Actions.enumAcciones.SituacionInicial) > 0)
                {
                    Actions _accInicial = lstActions.Where(ac => ac.TipoAccion == Actions.enumAcciones.SituacionInicial).First();
                    var id = _recordingObj.InsertNewActionRecord(_accInicial);

                    foreach (Actions _acc in lstActions.Where(ac => ac.TipoAccion != Actions.enumAcciones.SituacionInicial))
                    {
                        var idactionf = _recordingObj.insertNewActionField(id, _acc);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}

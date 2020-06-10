using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.contracts;

namespace GEOWNeg
{
    public class Neg_Journey : INeg_Journey
    {
        private IJourney _data_journey;

        public Neg_Journey(IJourney p_data_journey)
        {
            _data_journey = p_data_journey;
        }

        public Int64 New()
        {
            Int64 res = 0;

            try
            {
                res = _data_journey.New();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                res = 0;
            }

            return res;
        }

        public bool End(Int64 idJourney)
        {
            bool res = true;

            try
            {
                res = _data_journey.End(idJourney);
            }
            catch (Exception ex)
            {
                res = false;
            }

            return res;
        }
    }
}

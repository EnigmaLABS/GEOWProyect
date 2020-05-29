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
        private IJourney _neg_journey;

        public Neg_Journey(IJourney p_neg_journey)
        {
            _neg_journey = p_neg_journey;
        }

        public Int64 New()
        {
            Int64 res = 0;

            try
            {
                res = _neg_journey.New();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                res = 0;
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOWObj.contracts
{
    public interface INeg_Journey
    {
        Int64 New();
        bool End(Int64 idJourney);
    }
}

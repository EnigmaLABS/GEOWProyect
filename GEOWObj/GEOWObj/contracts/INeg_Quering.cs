using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.DTO;

namespace GEOWObj.contracts
{
    public interface INeg_Quering
    {
        List<GetJourneysDTO> GetJourneys();
        List<GetJourneyObjectsDTO> GetJourneyObjects(Int64 idJourney);
    }
}

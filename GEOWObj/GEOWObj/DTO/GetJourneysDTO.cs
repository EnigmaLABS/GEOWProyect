using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOWObj.DTO
{
    public class GetJourneysDTO
    {
        public Int64 idJourney { get; set; }
        public DateTime dtInicio { get; set; }
        public int numObjetos { get; set; }
        public Int64 numCoordenadasTotal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.contracts;

namespace GEOWObj.DTO
{
    public class GetJourneyObjectsDTO
    {
        public GetJourneyObjectsDTO()  {  }

        public Int64 idOBJ { get; set; }
        public string OBJDesc { get; set; }
        
        public string Color { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
    }
}

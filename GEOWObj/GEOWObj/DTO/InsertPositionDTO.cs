using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOWObj.DTO
{
    public class InsertPositionDTO
    {
        public string GUIDObject { get; set; }
        public string PointDesc { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        public string Color { get; set; }

        public Int64 idJourney { get; set; }
    }
}

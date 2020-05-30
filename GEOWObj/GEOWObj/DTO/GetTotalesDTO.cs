using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOWObj.DTO
{
    public class GetTotalesDTO
    {
        public Int64 TotalCoordenadas { get; set; }

        public Int64 TotalPoints { get; set; }

        public Int64 TotalTrayectos { get; set; }

        public Int64 PromedioCoordenadasFiguras
        {
            get => this.TotalCoordenadas / this.TotalPoints;
        }

        public Int64 PromedioCoordenadasTrayectos
        {
            get => this.TotalCoordenadas / this.TotalTrayectos;
        }
    }
}

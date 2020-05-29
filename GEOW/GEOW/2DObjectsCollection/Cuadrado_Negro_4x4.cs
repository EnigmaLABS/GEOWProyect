using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOW._2DObjectsCollection
{
    public class Cuadrado_Negro_4x4
    {
        private int altoLienzo;
        private int anchoLienzo;
        private int elementos_existentes;

        private INeg_BufferPositions _negObj;

        public Cuadrado_Negro_4x4(int p_altoLienzo, int p_anchoLienzo, int p_elementos_existentes, INeg_BufferPositions p_negObj)
        {
            altoLienzo = p_altoLienzo;
            anchoLienzo = p_anchoLienzo;
            elementos_existentes = p_elementos_existentes;

            _negObj = p_negObj;
        }

        public List<PointObj> Get(int num)
        {
            List<PointObj> res = new List<PointObj>();

            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Black,                           //color
                                    10, 10,                                 //pos inicial
                                    4, 4,                                   //alto-ancho
                                    PointObj.enumDireccion.Derecha,         //dirección
                                    anchoLienzo, altoLienzo, 
                                    "cuadrado_negro_4x4_" + (elementos_existentes+cont+1).ToString(), _negObj));
            }

            return res;
        }
    }
}

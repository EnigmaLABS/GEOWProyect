using System;
using System.Drawing;
using System.Collections.Generic;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOW.scenario
{
    public class scenario_1_tamanhosiguales_total_5xNum : scenario_base
    {
        public scenario_1_tamanhosiguales_total_5xNum(int p_altoLienzo, int p_anchoLienzo, int p_elementos_existentes, INeg_BufferPositions p_negobj) : base(p_altoLienzo, p_anchoLienzo, p_elementos_existentes, p_negobj)
        {
            base.EscenarioActual = enumEscenarios.scenario_1_tamanhosiguales_total_5xNum;
        }

        public override List<PointObj> Get(int num)
        {
            List<PointObj> res = new List<PointObj>();

            //100 cuadrados negros 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Black,                                       //color
                                            10, 10,                                     //pos inicial
                                            4, 4,                                       //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_negro_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj
                                            ));
            }

            //100 cuadrados azules 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Blue ,                                       //color
                                            100, 100,                                   //pos inicial
                                            4, 4,                                       //alto-ancho
                                            PointObj.enumDireccion.Abajo,               //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_azul_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj
                                            ));
            }

            //100 cuadrados verdes 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Green,                                       //color
                                            200, 200,                                   //pos inicial
                                            4, 4,                                       //alto-ancho
                                            PointObj.enumDireccion.Izquierda,           //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_verde_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj
                                            ));
            }

            //100 cuadrados amarillos 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Yellow,                                      //color
                                            200, 200,                                   //pos inicial
                                            4, 4,                                       //alto-ancho
                                            PointObj.enumDireccion.Izquierda,           //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_amarillo_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj
                                            ));
            }

            //100 cuadrados rojos 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Red,                                         //color
                                            10, 10,                                     //pos inicial
                                            4, 4,                                       //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_rojo_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj
                                            ));
            }

            return res;
        }
    }
}

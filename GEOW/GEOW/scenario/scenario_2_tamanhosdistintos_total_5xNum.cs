using System;
using System.Drawing;
using System.Collections.Generic;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOW.scenario
{
    public class scenario_2_tamanhosdistintos_total_5xNum : scenario_base
    {
        public scenario_2_tamanhosdistintos_total_5xNum(int p_altoLienzo, int p_anchoLienzo, int p_elementos_existentes, 
                                                        INeg_BufferPositions p_negobj,
                                                        INeg_UDPClient p_negUDPObj
                                                        ) : base(p_altoLienzo, p_anchoLienzo, p_elementos_existentes, p_negobj, p_negUDPObj)
        {
            base.EscenarioActual = enumEscenarios.scenario_2_tamanhosdistintos_total_5xNum;
        }

        public override List<PointObj> Get(int num)
        {
            List<PointObj> res = new List<PointObj>();

            //100 cuadrados negros 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Black,                                       //color
                                            10, 10,                                     //pos inicial
                                            10, 10,                                     //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_negro_10x10_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj, this._negudpobj
                                            ));
            }

            //100 cuadrados azules 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Blue,                                        //color
                                            15, 15,                                     //pos inicial
                                            15, 15,                                     //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_azul_4x4_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj, this._negudpobj
                                            ));
            }

            //100 cuadrados verdes 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Green,                                       //color
                                            20, 20,                                     //pos inicial
                                            20, 20,                                     //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_verde_20x20_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj, this._negudpobj
                                            ));
            }

            //100 cuadrados amarillos 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Yellow,                                      //color
                                            100, 100,                                   //pos inicial
                                            30, 30,                                     //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_amarillo_30x30_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj, this._negudpobj
                                            ));
            }

            //100 cuadrados rojos 4x4
            for (int cont = 0; cont < num; cont++)
            {
                res.Add(new PointObj(Color.Red,                                         //color
                                            140, 140,                                   //pos inicial
                                            40, 40,                                     //alto-ancho
                                            PointObj.enumDireccion.Derecha,             //dirección
                                            anchoLienzo, altoLienzo,
                                            "cuadrado_rojo_40x40_" + (elementos_existentes + cont + 1).ToString(),
                                            this._negobj, this._negudpobj
                                            ));
            }

            return res;
        }
    }
}

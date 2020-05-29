using System;
using System.Drawing;
using System.Collections.Generic;

using GEOWObj;
using GEOWObj.contracts;

namespace GEOW.scenario
{
    public class scenario_3_persecucion : scenario_base
    {
        public scenario_3_persecucion(int p_altoLienzo, int p_anchoLienzo, int p_elementos_existentes, INeg_BufferPositions p_negobj) : base(p_altoLienzo, p_anchoLienzo, p_elementos_existentes, p_negobj)
        {
            base.EscenarioActual = enumEscenarios.scenario_3_persecucion;
        }

        public override List<PointObj> Get()
        {
            List<PointObj> res = new List<PointObj>();

                res.Add(new PointObj(Color.Black,                                   //color
                                            10, 10,                                 //pos inicial
                                            20, 20,                                 //alto-ancho
                                            PointObj.enumDireccion.Derecha,         //dirección
                                            anchoLienzo, altoLienzo,
                                            "control", true, false, this._negobj));

            res.Add(new PointObj(Color.Red,                                         //color
                                        800, 500,                                   //pos inicial X-Y
                                        20, 20,                                     //alto-ancho
                                        PointObj.enumDireccion.Abajo,               //dirección
                                        anchoLienzo, altoLienzo,
                                        "perseguidor_" + (elementos_existentes + 2).ToString(), false, true, this._negobj));

            res.Add(new PointObj(Color.Red,                                         //color
                            800, 500,                                               //pos inicial X-Y
                            20, 20,                                                 //alto-ancho
                            PointObj.enumDireccion.Arriba,                          //dirección
                            anchoLienzo, altoLienzo,
                            "perseguidor_" + (elementos_existentes + 3).ToString(), false, true, this._negobj));

            res.Add(new PointObj(Color.Red,                                         //color
                            800, 500,                                               //pos inicial X-Y
                            20, 20,                                                 //alto-ancho
                            PointObj.enumDireccion.Derecha,                         //dirección
                             anchoLienzo, altoLienzo,
                            "perseguidor_" + (elementos_existentes + 4).ToString(), false, true, this._negobj));

            res.Add(new PointObj(Color.Red,                                         //color
                            800, 500,                                               //pos inicial X-Y
                            20, 20,                                                 //alto-ancho
                            PointObj.enumDireccion.Izquierda,                       //dirección
                            anchoLienzo, altoLienzo,
                            "perseguidor_" + (elementos_existentes + 5).ToString(), false,  true, this._negobj));




            return res;
        }
    }
}

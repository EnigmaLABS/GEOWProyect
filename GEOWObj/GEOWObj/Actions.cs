using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEOWObj
{
    public class Actions
    {
        private List<Actions> lstActions = new List<Actions>();

        public List<PointObj> ObjetosInicio;
        public List<PointObj> ObjetosAdd = new List<PointObj>();

        public bool TrazaInicio;
        public bool CambioDireccionInicio;
        public bool ActivoInicio;

        public DateTime FechaAccion;

        public enumAcciones TipoAccion;

        //dependencias
        private contracts.INeg_Actions _negObj;

        public enum enumAcciones { SituacionInicial = 0, AgregaObjetos = 1, CambioTraza = 2, CambioDireccion = 3, CambioActivacion = 4 }

        public Actions(List<PointObj> p_ObjetosInicio, bool p_TrazaInicio, bool p_CambioDireccionInicio, bool p_ActivoInicio, contracts.INeg_Actions p_negObj)
        {
            FechaAccion = DateTime.Now;

            TipoAccion = enumAcciones.SituacionInicial;

            ObjetosInicio = p_ObjetosInicio;
            TrazaInicio = p_TrazaInicio;
            CambioDireccionInicio = p_CambioDireccionInicio;
            ActivoInicio = p_ActivoInicio;

            lstActions.Add(this);

            _negObj = p_negObj;
        }

        public Actions(enumAcciones tipo)
        {
            this.TipoAccion = tipo;
        }

        public void RecordActions()
        {
            _negObj.RecordActions(lstActions);
        }

        //public List<Actions> GetActions()
        //{
        //    return lstActions;
        //}

        public void AgregaObjetos(List<PointObj> ObjetosAgregados)
        {
            lstActions.Add(new Actions(enumAcciones.AgregaObjetos)
            {
                FechaAccion = DateTime.Now,
                ObjetosAdd = ObjetosAgregados
            });
        }

        public void CambioTraza()
        {
            lstActions.Add(new Actions(enumAcciones.CambioTraza)
            {
                FechaAccion = DateTime.Now,
            });
        }

        public void CambioPosicion()
        {
            lstActions.Add(new Actions(enumAcciones.CambioDireccion)
            {
                FechaAccion = DateTime.Now,
            });
        }

        public void CambioActivacion()
        {
            lstActions.Add(new Actions(enumAcciones.CambioActivacion)
            {
                FechaAccion = DateTime.Now,
            });
        }
    }
}

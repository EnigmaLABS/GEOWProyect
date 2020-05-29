using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj;
using GEOWObj.DTO;
using GEOWObj.contracts;

namespace GEOWData
{
    public class data_Recording : IRecording
    {
        private string cnx_str = ConfigurationManager.ConnectionStrings["cnx_GEOW_STR"].ToString();

        public data_Recording()  {  }

        //-->>
        #region Actions record

        public Int64 InsertNewActionRecord(Actions Action)
        {
            Int64 res = 0;

            DataTable dtPoint = utiles.Reflections.GetPointsDataTable(Action.ObjetosInicio);

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertNewActionRecord";

            cmd.Parameters.AddWithValue("@RecordDate", Action.FechaAccion);
            cmd.Parameters.AddWithValue("@TraceIni", Action.TrazaInicio);
            cmd.Parameters.AddWithValue("@ChangesIni", Action.CambioDireccionInicio);
            cmd.Parameters.AddWithValue("@ActiveIni", Action.ActivoInicio);

            cmd.Parameters.AddWithValue("@tblPoints", dtPoint);

            cnx.Open();
            res = (Int64)cmd.ExecuteScalar();
            cnx.Close();

            return res;
        }

        public Int64 insertNewActionField(Int64 idRecord, Actions Action)
        {
            Int64 res = 0;
            string cmdtext = "";

            if (Action.ObjetosAdd != null && Action.ObjetosAdd.Count > 0)
            {
                cmdtext = "insertNewActionFieldWithPoints";
            }
            else
            {
                cmdtext = "insertNewActionField";
            }

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdtext;

            
            cmd.Parameters.AddWithValue("@idRecord", idRecord);
            cmd.Parameters.AddWithValue("@ActionDate", Action.FechaAccion);
            cmd.Parameters.AddWithValue("@idActionFieldType", (int)Action.TipoAccion);

            if (Action.ObjetosAdd != null && Action.ObjetosAdd.Count > 0)
            {
                DataTable dtPoint = utiles.Reflections.GetPointsDataTable(Action.ObjetosAdd);
                cmd.Parameters.AddWithValue("@tblPoints", dtPoint);
            }

            cnx.Open();
            res = (Int64)cmd.ExecuteScalar();
            cnx.Close();

            return res;
        }

        #endregion


        //-->>
        #region Position record & transfer to read model

        public void InsertPositions(List<InsertPositionDTO> Positions)
        {
            DataTable dtPositions = utiles.Reflections.GetPositionsDataTable(Positions);

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "write.InsertPositions";

            cmd.Parameters.AddWithValue("@tblPositions", dtPositions);

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void TransferPositionsToReadModel()
        {
            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "write.TransferPositions";

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        #endregion
    }
}

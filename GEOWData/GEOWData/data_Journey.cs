using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.contracts;

namespace GEOWData
{
    public class data_Journey : IJourney
    {
        private string cnx_str = ConfigurationManager.ConnectionStrings["cnx_GEOW_STR"].ToString();

        public data_Journey() {  }

        public Int64 New()
        {
            Int64 idjourney = 0;

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NewJourney";

            cnx.Open();
            idjourney = (Int64)cmd.ExecuteScalar();
            cnx.Close();

            return idjourney;
        }

        public bool End(Int64 idJourney)
        {
            Int64 idjourney = 0;

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EndJourney";

            cmd.Parameters.AddWithValue("@idJourney", idJourney);

            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();

            return true;
        }
    }
}

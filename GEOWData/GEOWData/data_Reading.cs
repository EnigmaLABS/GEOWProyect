using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.contracts;
using GEOWObj.DTO;

namespace GEOWData
{
    public class data_Reading : IReading
    {
        private string cnx_str = ConfigurationManager.ConnectionStrings["cnx_GEOW_STR"].ToString();

        public data_Reading() {  }

        public List<GetJourneysDTO> GetJourneys()
        {
            List<GetJourneysDTO> res = new List<GetJourneysDTO>();

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[read].GetJourneys";

            cnx.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GetJourneysDTO _item = new GetJourneysDTO()
                {
                    idJourney = Int64.Parse(reader["idJourney"].ToString()),
                    dtInicio = DateTime.Parse(reader["dtInicio"].ToString()),
                    numObjetos = int.Parse(reader["numObjetos"].ToString()),
                    numCoordenadasTotal = Int64.Parse(reader["numCoordenadasTotal"].ToString())
                };

                res.Add(_item);
            }

            reader.Close();

            cnx.Close();

            return res;
        }

        public List<GetJourneyObjectsDTO> GetJourneyObjects(Int64 idJourney)
        {
            List<GetJourneyObjectsDTO> res = new List<GetJourneyObjectsDTO>();

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[read].GetJourneyObjects";

            cmd.Parameters.AddWithValue("@idJourney", idJourney);

            cnx.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GetJourneyObjectsDTO _item = new GetJourneyObjectsDTO()
                {
                    idOBJ = Int64.Parse(reader["idPoint"].ToString()),
                    OBJDesc = reader["PointDesc"].ToString(),
                    Color = reader["Color"].ToString(),
                    Alto = int.Parse(reader["Height"].ToString()),
                    Ancho = int.Parse(reader["Width"].ToString())
                };

                res.Add(_item);
            }

            reader.Close();

            cnx.Close();

            return res;
        }


    }
}

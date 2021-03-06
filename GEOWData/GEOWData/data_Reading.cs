﻿using System;
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

        public GetTotalesDTO GetTotales()
        {
            GetTotalesDTO res = new GetTotalesDTO();

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[read].GetTotales";

            cnx.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                res = new GetTotalesDTO()
                {
                    TotalCoordenadas = Int64.Parse(reader["TotalCoordenadas"].ToString()),
                    TotalPoints = Int64.Parse(reader["TotalPoints"].ToString()),
                    TotalTrayectos = Int64.Parse(reader["TotalTrayectos"].ToString())
                };
            }

            reader.Close();

            cnx.Close();

            return res;
        }

        public List<GetPositionsDTO> GetPositions(Int64 idJourney, Int64 idObject)
        {
            List<GetPositionsDTO> res = new List<GetPositionsDTO>();

            SqlConnection cnx = new SqlConnection(cnx_str);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[read].GetPositions";

            cmd.Parameters.AddWithValue("@idJourney", idJourney);
            cmd.Parameters.AddWithValue("@idObject", idObject);

            cnx.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                GetPositionsDTO _pos = new GetPositionsDTO()
                {
                    dtPosition = DateTime.Parse(reader["dtPosition"].ToString()),
                    X = int.Parse(reader["X"].ToString()),
                    Y = int.Parse(reader["Y"].ToString())
                };

                res.Add(_pos);
            }

            reader.Close();

            cnx.Close();

            return res;
        }
    }
}

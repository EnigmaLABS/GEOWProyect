using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.DTO;
using GEOWObj.contracts;

namespace GEOWNeg
{
    public class Neg_Quering : INeg_Quering
    {
        private IReading _data_reading;

        public Neg_Quering(IReading p_data_reading)
        {
            _data_reading = p_data_reading;
        }

        public List<GetJourneysDTO> GetJourneys()
        {
            List<GetJourneysDTO> res = new List<GetJourneysDTO>();

            try
            {
                res = _data_reading.GetJourneys();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res.OrderBy(dt => dt.dtInicio).ToList();
        }

        public List<GetJourneyObjectsDTO> GetJourneyObjects(Int64 idJourney)
        {
            List<GetJourneyObjectsDTO> res = new List<GetJourneyObjectsDTO>();

            try
            {
                res = _data_reading.GetJourneyObjects(idJourney);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res.OrderBy(dt => dt.OBJDesc).ToList();
        }

        public GetTotalesDTO GetTotales()
        {
            GetTotalesDTO res = new GetTotalesDTO();

            try
            {
                res = _data_reading.GetTotales();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }

        public List<GetPositionsDTO> GetPositions(Int64 idJourney, Int64 idObject)
        {
            List<GetPositionsDTO> res = new List<GetPositionsDTO>();

            try
            {
                res = _data_reading.GetPositions(idJourney, idObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res.OrderByDescending(dt => dt.dtPosition).ToList();
        }
    }
}

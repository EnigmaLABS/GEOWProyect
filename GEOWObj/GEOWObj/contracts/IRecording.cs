using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.DTO;

namespace GEOWObj.contracts
{
    public interface IRecording
    {
        Int64 InsertNewActionRecord(Actions Action);
        Int64 insertNewActionField(Int64 idRecord, Actions Action);

        void InsertPositions(List<InsertPositionDTO> Positions);
        void TransferPositionsToReadModel();
    }
}

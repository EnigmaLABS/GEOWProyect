using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using GEOWObj.DTO;
using GEOWObj.contracts;

namespace GEOWNeg
{
    public class Neg_BufferPositions : INeg_BufferPositions
    {
        private static bool grabando = false;
        private int BufferLen;
        private List<InsertPositionDTO> _PositionsBuffer = new List<InsertPositionDTO>();

        private IRecording _recordingObj;

        public Neg_BufferPositions(int _BufferLen, IRecording p_recordingObj)
        {
            _PositionsBuffer.Clear();
            BufferLen = _BufferLen;

            _recordingObj = p_recordingObj;
        }

        public void InsertPosition(InsertPositionDTO _position)
        {
            while (grabando) { Thread.Sleep(100); }

            _PositionsBuffer.Add(_position);

            if (_PositionsBuffer.Count == BufferLen)
            {
                grabando = true;

                List<InsertPositionDTO> positionsToRecord = new List<InsertPositionDTO>(_PositionsBuffer);

                _PositionsBuffer.Clear();

                grabando = false;

                _recordingObj.InsertPositions(positionsToRecord);
            }
        }

        public void Flush()
        {
            grabando = true;

            List<InsertPositionDTO> positionsToRecord = new List<InsertPositionDTO>(_PositionsBuffer);

            _PositionsBuffer.Clear();

            grabando = false;

            _recordingObj.InsertPositions(positionsToRecord);
        }

        public void TransferPositionsToReadModel()
        {
            try
            {
                _recordingObj.TransferPositionsToReadModel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

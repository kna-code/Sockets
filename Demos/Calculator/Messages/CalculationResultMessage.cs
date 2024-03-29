using System;
using System.IO;
using SocketServer.Messages;
using SocketServer.Utils;

namespace Calculator.Messages
{
    [Serializable]
    public class CalculationResultMessage : SocketMessage
    {
        public int Value { get; set; }
        
        public override void Serialize(Stream stream)
        {
            BinaryUtils.WriteInt32(stream, Value);
        }

        public override void Deserialize(Stream stream)
        {
            Value = BinaryUtils.ReadInt32(stream);
        }
    }
}
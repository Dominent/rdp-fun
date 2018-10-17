using System;

/// <summary>
/// T.125 MCS is defined in:
/// http://www.itu.int/rec/T-REC-T.125-199802-I/
/// ITU-T T.125 Multipoint Communication Service Protocol Specification
/// </summary>
namespace NeroSoft.RDP.Network.T125
{
    public class T125Header : ISerializable<byte[]>
    {
        public byte[] Deserialize(byte[] buffer)
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }
}

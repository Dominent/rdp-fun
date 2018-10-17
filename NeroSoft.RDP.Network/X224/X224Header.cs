namespace NeroSoft.RDP.Network.X224
{
    using System;

    /// <summary>
    /// TPDUs are defined in:
    /// http://www.itu.int/rec/T-REC-X.224-199511-I/
    /// X.224: Information technology - Open Systems Interconnection - Protocol for providing the connection-mode transport service.
    /// 
    /// RDP uses only TPDUs of class 0, the "simple class" defined in section 8 of X.224.
    /// </summary>
    public class X224Header : ISerializable<byte[]>
    {
        public enum X224Type
        {
            CONNECTION_REQUEST = 0xe,
            CONNECTION_CONFIRM = 0xd0,
            DISCONNECTION_REQUEST = 0x80,
            DISCONNECTION_CONFIRM = 0xc0,
            EXPEDITED_DATA = 0x10,
            DATA_ACKNOWLEDGE = 0x61,
            EXPEDITET_ACKNOWLEDGE = 0x40,
            REJECT = 0x51,
            ERROR = 0x70,
            PROTOCOL_IDENTIFIER = 0x01
        }

        /// <summary>
        /// Length indicator field (LI), octet: [Required]
        /// </summary>
        public byte LengthIndicator { get; set; }

        /// <summary>
        /// Type Field, high nibble: [Required]
        /// </summary>
        public X224Type Code { get; set; }

        public short DestinationRef { get; set; }

        public short SourceRef { get; set; }

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

namespace NeroSoft.RDP.Network.TPKT
{
    using System;

    /// <summary>
    /// TPKTs are defined in:
    /// http://tools.ietf.org/html/rfc1006/
    /// RFC 1006 - ISO Transport Service on top of the TCP
    /// http://www.itu.int/rec/T-REC-T.123/
    /// ITU-T T.123 (01/2007) - Network-specific data protocol stacks for multimedia conferencing
    /// </summary>
    public class TPKTHeader : ISerializable<byte[]>
    {
        /// <summary>
        /// Version field, octet : [Required]
        /// </summary>
        public byte Version { get; set; }

        /// <summary>
        /// Reserved field, octet : [Required]
        /// </summary>
        public byte Reserved { get; set; }

        /// <summary>
        /// Packet Length field, octet: [Required]
        /// High Part + Low Part
        /// Ex: -> 00 2c -> 44
        ///     0000 0000 -> High Part
        ///     0010 1100 -> Low Part
        /// The Low part + High part, both represent a 16 bit number
        /// </summary>
        public byte Length { get; set; }

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

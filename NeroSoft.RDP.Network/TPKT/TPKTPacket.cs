namespace NeroSoft.RDP.Network.TPKT
{
    public class TPKTPacket<THeader> : ISerializable<byte[]>
        where THeader : TPKTHeader, new()
    {
        private const int TPKT_HEADER_LENGTH = 4;

        public TPKTPacket()
        {
            this.Header = new THeader();
        }

        public THeader Header { get; private set; }

        public byte[] Deserialize(byte[] buffer)
        {
            return Header.Deserialize(buffer);
        }

        public byte[] Serialize()
        {
            return this.Header.Serialize();
        }
    }
}

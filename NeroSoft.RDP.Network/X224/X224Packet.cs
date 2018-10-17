namespace NeroSoft.RDP.Network.X224
{
    public class X224Packet<THeader> : ISerializable<byte[]>
        where THeader : X224Header, new()
    {
        public X224Packet()
        {
            this.Header = new THeader();
        }

        public THeader Header { get; private set; }

        public byte[] Deserialize(byte[] buffer)
        {
            return this.Header.Deserialize(buffer);
        }

        public byte[] Serialize()
        {
            return this.Header.Serialize();
        }
    }
}

namespace NeroSoft.RDP.Network
{
    public interface ISerializable<T>
    {
        T Serialize();

        T Deserialize(T buffer);
    }
}

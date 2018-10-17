namespace NeroSoft.RDP.Network.T125.Sequence
{
    public class DomainParameters : ISequence
    {
        public int MaxChannelIds { get; set; }

        public int MaxUserIds { get; set; }

        public int MaxTokenIds { get; set; }

        public int MumPriorities { get; set; }

        public int MinThroughput { get; set; }

        public int MaxHeight { get; set; }

        public int MaxMCSPDUsize { get; set; }

        public int ProtocolVersion { get; set; }
    }
}

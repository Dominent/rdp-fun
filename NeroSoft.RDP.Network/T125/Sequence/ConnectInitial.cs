namespace NeroSoft.RDP.Network.T125.Sequence
{
    public class ConnectInitial : ISequence
    {
        public string CallingDomainSelector { get; set; }

        public string CalledDomainSelector { get; set; }

        public bool UpwardFlag { get; set; }

        public DomainParameters TargetParameters { get; set; }

        public DomainParameters MinimumParameters { get; set; }

        public DomainParameters MaximumParameters { get; set; }

        public string UserData { get; set; }
    }
}

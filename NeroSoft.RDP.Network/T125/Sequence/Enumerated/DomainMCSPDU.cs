﻿namespace NeroSoft.RDP.Network.T125.Sequence.Enumerated
{
    enum DomainMCSPDU
    {
        DomainMCSPDU_PlumbDomainIndication = 0,
        DomainMCSPDU_ErectDomainRequest = 1,
        DomainMCSPDU_MergeChannelsRequest = 2,
        DomainMCSPDU_MergeChannelsConfirm = 3,
        DomainMCSPDU_PurgeChannelsIndication = 4,
        DomainMCSPDU_MergeTokensRequest = 5,
        DomainMCSPDU_MergeTokensConfirm = 6,
        DomainMCSPDU_PurgeTokensIndication = 7,
        DomainMCSPDU_DisconnectProviderUltimatum = 8,
        DomainMCSPDU_RejectMCSPDUUltimatum = 9,
        DomainMCSPDU_AttachUserRequest = 10,
        DomainMCSPDU_AttachUserConfirm = 11,
        DomainMCSPDU_DetachUserRequest = 12,
        DomainMCSPDU_DetachUserIndication = 13,
        DomainMCSPDU_ChannelJoinRequest = 14,
        DomainMCSPDU_ChannelJoinConfirm = 15,
        DomainMCSPDU_ChannelLeaveRequest = 16,
        DomainMCSPDU_ChannelConveneRequest = 17,
        DomainMCSPDU_ChannelConveneConfirm = 18,
        DomainMCSPDU_ChannelDisbandRequest = 19,
        DomainMCSPDU_ChannelDisbandIndication = 20,
        DomainMCSPDU_ChannelAdmitRequest = 21,
        DomainMCSPDU_ChannelAdmitIndication = 22,
        DomainMCSPDU_ChannelExpelRequest = 23,
        DomainMCSPDU_ChannelExpelIndication = 24,
        DomainMCSPDU_SendDataRequest = 25,
        DomainMCSPDU_SendDataIndication = 26,
        DomainMCSPDU_UniformSendDataRequest = 27,
        DomainMCSPDU_UniformSendDataIndication = 28,
        DomainMCSPDU_TokenGrabRequest = 29,
        DomainMCSPDU_TokenGrabConfirm = 30,
        DomainMCSPDU_TokenInhibitRequest = 31,
        DomainMCSPDU_TokenInhibitConfirm = 32,
        DomainMCSPDU_TokenGiveRequest = 33,
        DomainMCSPDU_TokenGiveIndication = 34,
        DomainMCSPDU_TokenGiveResponse = 35,
        DomainMCSPDU_TokenGiveConfirm = 36,
        DomainMCSPDU_TokenPleaseRequest = 37,
        DomainMCSPDU_TokenPleaseConfirm = 38,
        DomainMCSPDU_TokenReleaseRequest = 39,
        DomainMCSPDU_TokenReleaseConfirm = 40,
        DomainMCSPDU_TokenTestRequest = 41,
        DomainMCSPDU_TokenTestConfirm = 42,
        DomainMCSPDU_enum_length = 43
    };
}

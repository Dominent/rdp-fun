namespace NeroSoft.RDP.Network.T125.Sequence.Enumerated
{
    enum MCS_Result
    {
        MCS_Result_successful = 0,
        MCS_Result_domain_merging = 1,
        MCS_Result_domain_not_hierarchical = 2,
        MCS_Result_no_such_channel = 3,
        MCS_Result_no_such_domain = 4,
        MCS_Result_no_such_user = 5,
        MCS_Result_not_admitted = 6,
        MCS_Result_other_user_id = 7,
        MCS_Result_parameters_unacceptable = 8,
        MCS_Result_token_not_available = 9,
        MCS_Result_token_not_possessed = 10,
        MCS_Result_too_many_channels = 11,
        MCS_Result_too_many_tokens = 12,
        MCS_Result_too_many_users = 13,
        MCS_Result_unspecified_failure = 14,
        MCS_Result_user_rejected = 15,
        MCS_Result_enum_length = 16
    };
}

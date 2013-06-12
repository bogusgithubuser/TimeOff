using System.Runtime.Serialization;

namespace TimeOff.ComponentModel
{
    [DataContract]
    public enum RequestStates
    {
        [EnumMember]
        Submitted,

        [EnumMember]
        Approved,

        [EnumMember]
        Rejected
    }
}
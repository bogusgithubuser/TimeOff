using System.Runtime.Serialization;

namespace TimeOff.ComponentModel
{
    [DataContract]
    public enum UserRoles
    {
        [EnumMember]
        Employee,

        [EnumMember]
        ProjectManager,

        [EnumMember]
        HumanResources
    }
}
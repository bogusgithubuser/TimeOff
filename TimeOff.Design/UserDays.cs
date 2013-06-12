using System.Runtime.Serialization;

namespace TimeOff.ComponentModel
{
    [DataContract]
    public class UserDays
    {
        public string UserId { get; set; }
        public Days Days { get; set; }
    }
}
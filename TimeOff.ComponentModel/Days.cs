using System.Runtime.Serialization;

namespace TimeOff.ComponentModel
{
    [DataContract]
    public class Days
    {
        public int Taken { get; set; }
        public int Remaining { get; set; }
    }
}
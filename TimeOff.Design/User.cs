using System.Runtime.Serialization;

namespace TimeOff.ComponentModel
{
    [DataContract]
    public class User
    {
        public string Id { get; set; }
        public UserRoles Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
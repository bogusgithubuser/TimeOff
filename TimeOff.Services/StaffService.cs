using TimeOff.ComponentModel;

namespace TimeOff.Services
{
    public class StaffService: IStaffService
    {
        public string Add(User user)
        {
            return string.Empty;
        }

        public void Update(User user)
        {
            
        }

        public void Delete(string userId)
        {
            
        }

        public User Get(string userId)
        {
            return new User();
        }
    }
}
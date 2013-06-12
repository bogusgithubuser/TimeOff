using System;
using TimeOff.ComponentModel;

namespace TimeOff.Services
{
    public class VacationService : IVacationService
    {
        public string SubmitRequest(string userId, DateTime[]  days)
        {
            return string.Empty;
        }

        public void CancelRequest(string requestId)
        {
            
        }

        public void ApproveRequest(string requestId)
        {
            
        }

        public void RejectRequest(string requestId)
        {
            
        }

        public Days GetAvailableDaysByUser(string userid)
        {
            return new Days();
        }

        public UserDays[] GetAvailableDaysByAllUsers()
        {
            return new UserDays[0];
        }
    }
}
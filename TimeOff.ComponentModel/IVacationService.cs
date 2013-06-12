using System;
using System.ServiceModel;

namespace TimeOff.ComponentModel
{
    [ServiceContract(Namespace = "TimeOff")]
    public interface IVacationService
    {
        [OperationContract]
        string SubmitRequest(string userId, DateTime[] days);
        
        [OperationContract]
        void CancelRequest(string requestId);
        
        [OperationContract]
        void ApproveRequest(string requestId);
        
        [OperationContract]
        void RejectRequest(string requestId);
        
        [OperationContract]
        Days GetAvailableDaysByUser(string userid);

        [OperationContract]
        UserDays[] GetAvailableDaysByAllUsers();
    }
}
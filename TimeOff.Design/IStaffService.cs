using System.ServiceModel;

namespace TimeOff.ComponentModel
{
    [ServiceContract]
    public interface IStaffService
    {
        [OperationContract]
        string Add(User user);

        [OperationContract]
        void Update(User user);

        [OperationContract]
        void Delete(string userId);

        [OperationContract]
        User Get(string userId);
    }
}
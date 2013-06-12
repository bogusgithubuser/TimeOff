namespace TimeOff.ComponentModel
{
    public interface INotifier
    {
        void Subscribe(string requestId, string email, RequestStates requestState);
        void Notify(string requestId, string email);
    }
}
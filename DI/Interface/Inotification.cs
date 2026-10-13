namespace DI.Interface
{
    public interface INotification
    {
        string Notify(string message);
        void Notify(string message, string recipient);

    }
}

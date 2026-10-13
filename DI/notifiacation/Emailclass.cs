using DI.Interface;
namespace DI.notifiacation
{
    public class Emailclass : INotification
    {
        public string Notify(string message)
        {
            return($"Email notification: {message}");
        }

        public void Notify(string message, string recipient)
        {
            Console.WriteLine($"Email notification to {recipient}: {message}");
        }
    }
}

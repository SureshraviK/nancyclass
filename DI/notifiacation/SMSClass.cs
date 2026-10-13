using DI.Interface;
namespace DI.notifiacation
{
    public class SMSClass : INotification
    {
        public string Notify(string message)
        {
            return($"SMS notification: {message}");
        }

        public void Notify(string message, string recipient)
        {
            Console.WriteLine($"SMS notification to {recipient}: {message}");
        }
    }
}

namespace nancyclass
{

    interface INotification
    {
        void Notify(string message);

    }
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }
    public class PushNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push notification: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS notification: {message}");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            SmsNotification obj = new SmsNotification();
            obj.Notify("Hello, this is a test notification.");

            INotification notification = new SmsNotification();
            notification.Notify("Hello, this is a test notification Inotification object.");


        }
    }
}

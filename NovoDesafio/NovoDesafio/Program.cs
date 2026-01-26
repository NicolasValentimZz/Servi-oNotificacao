using NovoDesafio.Entities;
using NovoDesafio.Services;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Email or SMS: ");
        string response = Console.ReadLine().ToUpper();

        INotification notification;

        if (response == "EMAIL")
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Subject: ");
            string subject = Console.ReadLine();
            Console.Write("Body: ");
            string body = Console.ReadLine();
            
            notification = new EmailNotification(title, subject, body);
        }

        else
        {
            Console.Write("Body: ");
            string body = Console.ReadLine();

            notification = new SMSNotification(body);
        }
        
        NotificationService notificationService = new NotificationService(notification);
        
        Console.WriteLine(notificationService.SendNotification());
        
        Console.WriteLine(notification);
        
    }
}
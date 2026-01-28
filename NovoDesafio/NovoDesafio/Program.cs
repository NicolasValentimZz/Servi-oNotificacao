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

        else if (response == "SMS")
        {
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Body: ");
            string body = Console.ReadLine();
            
            notification = new SMSNotification(phoneNumber, body);
        }
        else
        {
            Console.Write("Enter E-mail or SMS");
            return;
        }

        NotificationService service = new NotificationService(notification);
        service.SendNotification();
    }
}
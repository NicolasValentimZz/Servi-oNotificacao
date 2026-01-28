using NovoDesafio.Services;

namespace NovoDesafio.Entities;

public class SMSNotification : INotification
{
   public string Body { get; set; }
   public string PhoneNumber { get; set; }

    public SMSNotification(string body, string phoneNumber)
    {
       Body = body ?? throw new ArgumentNullException(nameof(body));
       PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
    }

    public bool ReciveMessage(string message)
    {
        if (string.IsNullOrEmpty(message)) return false;
        Body = message;
        return !string.IsNullOrEmpty(PhoneNumber);
    }

    public void Notification()
    {
        Console.WriteLine("SMS Notification");
    }
}
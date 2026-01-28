using NovoDesafio.Services;

namespace NovoDesafio.Entities;

public class EmailNotification : INotification
{
    public string Title { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public EmailNotification(string title, string subject, string body)
    {
        Title = title;
        Subject = subject;
        Body = body ?? throw new ArgumentNullException(nameof(body));
    }

    public bool ReciveMessage(string message)
    {
        if (string.IsNullOrEmpty(message)) return false;
        Body = message;
        return true;
    }

    public void Notification()
    {
        Console.WriteLine("E-mail Notification");
    }
    
}
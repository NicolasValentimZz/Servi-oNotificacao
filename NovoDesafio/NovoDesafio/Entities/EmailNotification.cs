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
        Body = body;
    }

    public bool ReciveMessage(string message)
    {
        if (message != String.Empty)
        {
            return message == Title && message ==  Subject && message == Body;
        }
        return false;
    }

    public override string ToString()
    {
        return "Message from " + Title;
    }

}
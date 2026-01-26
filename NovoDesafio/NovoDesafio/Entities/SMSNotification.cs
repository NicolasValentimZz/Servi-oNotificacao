using NovoDesafio.Services;

namespace NovoDesafio.Entities;

public class SMSNotification : INotification
{
   public string Body { get; set; }

    public SMSNotification(string body)
    {
       Body = body;
    }

    public bool ReciveMessage(string message)
    {
        if (message != String.Empty)
        {
            return message == Body;
        }
        return false;
    }

    public override string ToString()
    {
        return "New message - " + Body;
    }
}
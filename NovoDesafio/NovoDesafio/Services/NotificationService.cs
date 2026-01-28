namespace NovoDesafio.Services;

public class NotificationService
{
    private INotification _notification;
    
    public NotificationService(INotification notification)
    {
        _notification = notification;
    }

    public void SendNotification()
    {
         _notification.Notification();
    }
}
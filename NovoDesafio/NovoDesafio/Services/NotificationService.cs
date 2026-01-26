namespace NovoDesafio.Services;

public class NotificationService
{
    private INotification _notification;
    
    public NotificationService(INotification notification)
    {
        _notification = notification;
    }

    public string SendNotification()
    {
        return _notification.Notification();
    }
}
namespace HexaDemo.Modules.Domain.Base.Exceptions;

public class DomainException : Exception
{
    public List<Notification> Notifications { get; private set; } = new();
    
    public DomainException(List<Notification> notifications)
    {
        Notifications = notifications;
    }
}
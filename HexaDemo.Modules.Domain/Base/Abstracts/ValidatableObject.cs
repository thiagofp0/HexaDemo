using HexaDemo.Modules.Domain.Base.Exceptions;

namespace HexaDemo.Modules.Domain.Base.Abstracts;

public abstract class ValidatableObject
{
    public List<Notification> Notifications { get; private set; } = new();
    public bool IsValid => !Notifications.Any();
    
    public void AddNotification(Notification notification) => Notifications.Add(notification);
    public void AddNotifications(IEnumerable<Notification> notifications) => Notifications.AddRange(notifications);
    protected void ClearNotifications() => Notifications.Clear();

    public bool AssertValidation()
    {
        if(Notifications.Any())
            throw new DomainException(Notifications);
        return true;
    }

}


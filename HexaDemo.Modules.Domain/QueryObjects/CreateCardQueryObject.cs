using HexaDemo.Modules.Domain.Base;
using HexaDemo.Modules.Domain.Base.Abstracts;
using HexaDemo.Modules.Domain.Entities;

namespace HexaDemo.Modules.Domain.QueryObjects;

public class CreateCardQueryObject : ValidatableObject
{
    public string Title { get; private set; }
    public User AssignedUser { get; private set; }
    
    public CreateCardQueryObject(string? title, User assignedUser)
    {
        Title = title ?? string.Empty;
        AssignedUser = assignedUser;

        if (string.IsNullOrWhiteSpace(title))
        {
            AddNotification(Notification.Create("Title is required"));
        }

        AssertValidation();
    }
}
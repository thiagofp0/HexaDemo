namespace HexaDemo.Modules.Domain.Base;

public class Notification
{
    public string Message { get; private set; }

    private Notification(string message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return Message;
    }
    
    public static Notification Create(string message)
    {
        return new Notification(message);
    }
}
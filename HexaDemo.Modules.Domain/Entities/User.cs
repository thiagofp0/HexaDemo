namespace HexaDemo.Modules.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = String.Empty;
    public string username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    
    public User(string name, string email, string username, string password)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        this.username = username;
        Password = password;
    }
}
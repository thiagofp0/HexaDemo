namespace HexaDemo.Modules.Domain.Base.Abstracts;

public class Entity : ValidatableObject
{
    public Guid Id { get; protected set; }
}
using HexaDemo.Modules.Domain.Base.Abstracts;
using HexaDemo.Modules.Domain.Base.Enums;
using HexaDemo.Modules.Domain.ValueObjects;

namespace HexaDemo.Modules.Domain.Entities;

public class Card : Entity
{
    public string Title { get; set; } = string.Empty;
    public User? AssignedTo { get; set; }
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    public List<CardStatusLog> StatusHistory { get; set; } = new();

    public Card(string title, User? assignedTo)
    {
        Title = title;
        AssignedTo = assignedTo;
    }
}
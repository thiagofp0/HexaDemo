using HexaDemo.Modules.Domain.Entities;
using HexaDemo.Modules.Domain.ValueObjects;

namespace HexaDemo.Modules.Domain.ValueObjects;

public class CardStatusLog
{
    public DateTime ChangedAt { get; private set; } = DateTime.Now;
    public CardStatus Status { get; private set; }
    public User ChangedBy { get; private set; }
    
    public CardStatusLog(CardStatus status, User changedBy)
    {
        Status = status;
        ChangedBy = changedBy;
    }
}
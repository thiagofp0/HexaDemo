using HexaDemo.Modules.Domain.Base;
using HexaDemo.Modules.Domain.Base.Abstracts;

namespace HexaDemo.Modules.Domain.ValueObjects;

public class CardStatus : ValueObject
{
    public string Label { get; private set; }

    public static readonly string[] PossibleValuesForLabel = {"Todo", "In Progress", "Done"};
    
    public CardStatus(string label)
    {
        Label = NormalizeLabel(label);
        
        if (string.IsNullOrWhiteSpace(Label))
        {
            AddNotification(Notification.Create("Label not valid"));
        }

        AssertValidation();
    }
    
    private static string NormalizeLabel(string label)
    {
        if (string.IsNullOrWhiteSpace(label))
        {
            return "Todo";
        }

        label = label.Trim().ToLower();

        if (PossibleValuesForLabel.Contains(label))
        {
            return label;
        }

        return "Todo";
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Label;
    }
}
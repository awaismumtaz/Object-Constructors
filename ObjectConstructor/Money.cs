namespace ObjectConstructor;

public class Money
{
    public Decimal Amount { get; private set; }
    public Currency CurrencyType { get; private set; }

    public Money(decimal amount, Currency currencyType)
    {
        Amount = amount;
        CurrencyType = currencyType;
    }
    
    
}
namespace ObjectConstructor;

public class Money
{
    public Decimal Amount { get; set; }
    public Currency Currency { get; set; }

    public Money(Decimal amount, Currency currency)
    {
        this.Amount = amount;
        this.Currency = currency;
    }
    
}
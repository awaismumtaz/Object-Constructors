namespace ObjectConstructor;

public class CurrencyConverter
{
    public decimal Dollar { get; }
    public decimal Euro { get; }
    public decimal SEK { get; }

    public CurrencyConverter(decimal dollar, decimal euro, decimal sek)
    {
        Dollar = dollar;
        Euro = euro;
        SEK = sek;
    }

    public decimal DollarToSEK(decimal amount)
    {
        return amount * Dollar;
    }

    public decimal EuroToDollar(decimal amount)
    {
        return amount * Euro;
    }

    public decimal SEKToDollar(decimal amount)
    {
        return amount * Dollar;
    }
}
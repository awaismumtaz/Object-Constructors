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

    public decimal DollarToSek(decimal amount)
    {
        return amount / Dollar;
    }

    public decimal EuroToDollar(decimal amount)
    {
        return amount / Euro * Dollar;
    }

    public decimal SekToDollar(decimal amount)
    {
        return amount * Dollar;
    }
    
    public decimal DollarToEuro(decimal amount)
    {
        return amount / Dollar * Euro;
    }
    
    public decimal SekToEuro(decimal amount)
    {
        return amount / SEK * Euro;
    }
    
    public decimal EuroToSek(decimal amount)
    {
        return amount / Euro * SEK ;
    }
}
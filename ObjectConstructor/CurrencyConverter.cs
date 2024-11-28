namespace ObjectConstructor;

public class CurrencyConverter
{
    public Decimal Dollar { get; set; }
    public Decimal Euro { get; set; }
    public Decimal SEK { get; set; }

    public CurrencyConverter(Decimal dollar, Decimal euro, Decimal sek)
    {
        this.Dollar = dollar;
        this.Euro = euro;
        this.SEK = sek;
    }
	
    public Decimal DollarToEuro()
    {
        return this.Dollar * this.Euro ;
    }

    public Decimal DollarToSek()
    {
        return this.Dollar * this.SEK;
    }

    public Decimal EuroToDollar()
    {
        return this.Euro * this.Dollar;
    }

    public Decimal EuroToSek()
    {
        return this.Euro * this.SEK;
    }

    public Decimal SekToEuro()
    {
        return this.SEK * this.Euro;
    }

    public Decimal SekToDollar()
    {
        return this.SEK * this.Dollar;
    }
}
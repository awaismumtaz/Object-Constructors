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

    public void ChangeCurrency(CurrencyConverter converter, Currency newCurrency)
    {
        if (CurrencyType == newCurrency)
        {
            return;
        }

        switch (CurrencyType)
        {
            case Currency.Dollar:
                if (newCurrency == Currency.SEK )
                {
                    Amount = converter.DollarToSek(Amount);
                }
                else if (newCurrency == Currency.Euro)
                {
                    Amount = converter.DollarToEuro(Amount);
                } 
                break;
            
            case Currency.Euro:
                if (newCurrency == Currency.SEK )
                {
                    Amount = converter.EuroToSek(Amount);
                }
                else if (newCurrency == Currency.Dollar)
                {
                    Amount = converter.EuroToDollar(Amount);
                } 
                break;
            
            case Currency.SEK:
                if (newCurrency == Currency.Dollar )
                {
                    Amount = converter.SekToDollar(Amount);
                }
                else if (newCurrency == Currency.Euro)
                {
                    Amount = converter.SekToEuro(Amount);
                } 
                break;
        }
    }
}
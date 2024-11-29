// See https://aka.ms/new-console-template for more information

using ObjectConstructor;
// Initialize CurrencyConverter
CurrencyConverter converter = new CurrencyConverter(0.091m, 0.086m, 1.0m);

//Create Money Instances
Money moneyInUsd = new Money(200m, Currency.Dollar);
Money moneyInEur = new Money(300m, Currency.Euro);
Money moneyInSek = new Money(250m, Currency.SEK);

//Account opening
Account accountUsd = new Account {Balance = moneyInUsd, Id = 1};
Console.WriteLine($"USD Account ID: {accountUsd.Id}, Balance: {accountUsd.Balance.Amount} $");

Account accountEuro = new Account {Balance = moneyInEur, Id = 2};
Console.WriteLine($"EURO Account ID: {accountEuro.Id}, Balance: {accountEuro.Balance.Amount} \u20ac");

Account accountSek = new Account {Balance = moneyInSek, Id = 3};
Console.WriteLine($"SEK Account ID: {accountSek.Id}, Balance: {accountSek.Balance.Amount} Kr");

// Currency Converter

//Convert USD to SEK
moneyInUsd.ChangeCurrency(converter, Currency.SEK);
Console.WriteLine($"Converted USD amount in SEK : {moneyInUsd.Amount} Kr");

//Convert Euros to Dollars
moneyInEur.ChangeCurrency(converter, Currency.Dollar);
Console.WriteLine($"Converted EURO amount in Dollars : {moneyInEur.Amount} $");

//Convert SEK to Euro
moneyInSek.ChangeCurrency(converter, Currency.Euro);
Console.WriteLine($"Converted SEK amount in Euro : {moneyInSek.Amount} \u20ac");


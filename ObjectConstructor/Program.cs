// See https://aka.ms/new-console-template for more information

using ObjectConstructor;

CurrencyConverter myObj = new CurrencyConverter(0.095M, 0.085M, 1M);

Console.WriteLine(myObj.EuroToDollar());
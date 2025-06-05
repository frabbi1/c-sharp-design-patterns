// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

Logger.Instance.Log("This is a singleton logger message.");

// Example usage of Factory Method pattern
foreach(var factory in DiscountServiceFactoryProvider.Factories)
{
    factory.CreateDiscountService();
}
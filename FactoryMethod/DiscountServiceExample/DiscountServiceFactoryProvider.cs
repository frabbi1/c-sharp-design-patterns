namespace DesignPatterns.FactoryMethod.DiscountServiceExample
{
    public class DiscountServiceFactoryProvider
    {
        public static List<DiscountFactory> Factories { get; } =
        [
            new CodeDiscountFactory(),
            new CountryDiscountFactory(1),
            new CountryDiscountFactory(2),
            new CountryDiscountFactory(3),
            new CountryDiscountFactory(10)
        ];
    }
}

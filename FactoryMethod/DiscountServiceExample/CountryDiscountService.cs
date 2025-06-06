namespace DesignPatterns.FactoryMethod.DiscountServiceExample
{
    public class CountryDiscountService : BaseDiscountService
    {
        private readonly int _code;
        public CountryDiscountService(int code)
        {
            _code = code;
            Console.WriteLine("CountryDiscountService created with discount percentage: " + DiscountPercentage);
        }
        public override int DiscountPercentage
        {
            get
            {
                if (_code == 1)
                {
                    return 5; // Example for country code 1
                }
                else if (_code == 2)
                {
                    return 15; // Example for country code 2
                }
                else
                {
                    return 0; // Default case for other country codes
                }
            }
        }
    }
}

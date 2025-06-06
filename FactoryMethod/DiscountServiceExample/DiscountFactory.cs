namespace DesignPatterns.FactoryMethod.DiscountServiceExample
{
    public abstract class DiscountFactory
    {
        public abstract BaseDiscountService CreateDiscountService();
        //public static DiscountFactory GetFactory(string factoryType)
        //{
        //    if (factoryType == "Code")
        //    {
        //        return new CodeDiscountFactory();
        //    }
        //    else if (factoryType == "Country")
        //    {
        //        return new CountryDiscountFactory();
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Invalid factory type");
        //    }
        //}
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        public CodeDiscountFactory()
        {

        }
        public override BaseDiscountService CreateDiscountService()
        {
            return new CodeDiscountService();
        }
    }

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly int code;
        public CountryDiscountFactory(int code)
        {
            this.code = code;
        }
        public override BaseDiscountService CreateDiscountService()
        {
            return new CountryDiscountService(code);
        }
    }
}

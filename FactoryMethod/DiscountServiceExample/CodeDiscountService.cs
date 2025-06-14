﻿namespace DesignPatterns.FactoryMethod.DiscountServiceExample
{
    public class CodeDiscountService : BaseDiscountService
    {
        public CodeDiscountService()
        {
            Console.WriteLine("CodeDiscountService created with discount percentage: " + DiscountPercentage);
        }

        public override int DiscountPercentage => 10;
    }
}

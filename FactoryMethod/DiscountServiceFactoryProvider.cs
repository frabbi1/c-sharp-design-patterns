using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class DiscountServiceFactoryProvider
    {
        private static readonly List<DiscountFactory> factories = new List<DiscountFactory>()
        {
            new CodeDiscountFactory(),
            new CountryDiscountFactory(1),
            new CountryDiscountFactory(2),
            new CountryDiscountFactory(3),
            new CountryDiscountFactory(10)
        };

        public static List<DiscountFactory> Factories => factories;
    }
}

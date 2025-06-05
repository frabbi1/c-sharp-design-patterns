using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class BaseDiscountService
    {
        public abstract int DiscountPercentage { get; }
    }
}

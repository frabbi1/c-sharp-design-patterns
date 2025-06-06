using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        /// <inheritdoc />
        public int GetBonus()
        {
            return 50;
        }

        public int GetHouseRent()
        {
            return 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class PermanentEmployeeFactory : IEmployeeFactory
    {
        /// <inheritdoc />
        public void Create(Employee employee)
        {
            var manager = new PermanentEmployeeManager();
            employee.Bonus = manager.GetBonus();
            employee.HouseRent = manager.GetHouseRent();
        }
    }
}

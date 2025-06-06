using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class TempEmployeeFactory : IEmployeeFactory
    {
        /// <inheritdoc />
        public void Create(Employee employee)
        {
            var manager = new TempEmployeeManger();
            employee.Bonus = manager.GetBonus();
        }
    }
}

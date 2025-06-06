using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class ContractEmployeeFactory : IEmployeeFactory
    {
        /// <inheritdoc />
        public void Create(Employee employee)
        {
            var manager = new ContractEmployeeManager();
            employee.Bonus = manager.GetBonus();
            employee.TransportFee = manager.TransportFee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        /// <inheritdoc />
        public int GetBonus()
        {
            return 10;
        }

        public int TransportFee => 30;
    }
}

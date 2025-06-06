using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class TempEmployeeManger : IEmployeeManager
    {
        /// <inheritdoc />
        public int GetBonus()
        {
            return 5;
        }
    }
}

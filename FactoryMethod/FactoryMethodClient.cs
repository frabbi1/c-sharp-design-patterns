using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod.DiscountServiceExample;
using DesignPatterns.FactoryMethod.EmployeeExample;

namespace DesignPatterns.FactoryMethod
{
    public static class FactoryMethodClient
    {
        public static void RunForDiscountServiceExample()
        {
            foreach (var factory in DiscountServiceFactoryProvider.Factories)
            {
                factory.CreateDiscountService();
            }
        }

        public static void RunForEmployeeExample()
        {
            var employeeList = new List<Employee>(); // database employee table.

            // let's assume employee name & type is coming from some input / configuration file.
            var employeeNameTypeTuples = new List<(string name, int type)>()
            {
                ("Fazlay", 0),
                ("Hasan", 1),
                ("Ahmed", 2),
                ("Kabir", 0),
            };

            foreach (var item in employeeNameTypeTuples)
            {
                var emp = EmployeeFactory.CreateEmployee(item);
                employeeList.Add(emp);
            }

            employeeList.ForEach(ShowEmployee);
        }

        private static void ShowEmployee(Employee employee)
        {
            Console.WriteLine($"Name: {employee.EmployeeName}");
            Console.WriteLine($"Type: {employee.EmployeeType}");
            Console.WriteLine($"Bonus: {employee.Bonus}");
            Console.WriteLine($"House Rent: {employee.HouseRent}");
            Console.WriteLine($"Transport Fee: {employee.TransportFee}");
            Console.WriteLine($"Id: {employee.EmployeeId}");
            Console.WriteLine();
        }
    }
}

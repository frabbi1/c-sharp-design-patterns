namespace DesignPatterns.FactoryMethod.EmployeeExample
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee((string name, int type) item)
        {
            var emp = new Employee
            {
                EmployeeName = item.name,
                EmployeeType = item.type,
            };

            var factory = Factories[emp.EmployeeType];

            factory.Create(emp);

            return emp;
        }

        private static readonly Dictionary<int, IEmployeeFactory> Factories = new()
        {
            {0, new PermanentEmployeeFactory()},
            {1, new ContractEmployeeFactory()},
            {2, new TempEmployeeFactory()},
        };
    }
}

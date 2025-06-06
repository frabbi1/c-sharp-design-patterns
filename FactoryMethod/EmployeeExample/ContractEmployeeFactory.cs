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

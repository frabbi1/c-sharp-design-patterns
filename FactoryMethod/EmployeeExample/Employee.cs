namespace DesignPatterns.FactoryMethod.EmployeeExample;

public class Employee
{
    public string EmployeeId { get; } = Guid.NewGuid().ToString();
    public string? EmployeeName { get; set; }
    public required int EmployeeType { get; set; }
    public int Bonus { get; set; } = 0;
    public int HouseRent { get; set; } = 0;
    public int TransportFee { get; set; } = 0;
}
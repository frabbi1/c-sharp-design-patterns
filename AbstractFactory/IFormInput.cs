namespace DesignPatterns.AbstractFactory;

public interface IFormInput
{
    string Legend();
    string Type();
    bool IsRequired();
}
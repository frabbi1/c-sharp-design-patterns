namespace DesignPatterns.AbstractFactory;

public interface IForm
{
    ICollection<IFormInput> CreateFormInputs();
    ICollection<IButton> CreateFormButtons();

    string GetTitle();
}
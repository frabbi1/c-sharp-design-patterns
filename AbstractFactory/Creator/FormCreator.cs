namespace DesignPatterns.AbstractFactory.Creator;

public class FormCreator
{
    private readonly ICollection<IFormInput> _formInputs;
    private readonly ICollection<IButton> _formButtons;
    private readonly string _formTitle;

    public FormCreator(IForm form)
    {
        _formInputs = form.CreateFormInputs();
        _formButtons = form.CreateFormButtons();
        _formTitle = form.GetTitle();
    }

    public void Create()
    {
        Console.WriteLine(_formTitle);
        Console.WriteLine("-----------------------------");
        foreach (var input in _formInputs)
        {
            Console.WriteLine($"type: {input.Type()}");
            Console.WriteLine($"legend: {input.Legend()}");
            Console.WriteLine($"required: {input.IsRequired()}");
            Console.WriteLine();
        }

        Console.WriteLine("****************************");

        foreach (var button in _formButtons)
        {
            Console.WriteLine($"name: {button.Name()}");
            Console.WriteLine($"color: {button.Color()}");
            Console.WriteLine();
        }
    }
}
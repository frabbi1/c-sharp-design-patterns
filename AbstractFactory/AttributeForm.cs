namespace DesignPatterns.AbstractFactory;

public class AttributeForm : IForm
{
    private readonly string _title;
    public AttributeForm(string title)
    {
        _title = title;
    }

    /// <inheritdoc />
    public string GetTitle()
    {
        return _title;
    }

    /// <inheritdoc />
    public ICollection<IFormInput> CreateFormInputs()
    {
        return new List<IFormInput>()
        {
            new TextInput("Name Input", true),
            new TextInput("Description Input", false),
            new DropdownInput("Choose Category"),
        };
    }

    /// <inheritdoc />
    public ICollection<IButton> CreateFormButtons()
    {
        return new List<IButton>()
        {
            new SaveButton(),
            new CancelButton(),
        };
    }
}
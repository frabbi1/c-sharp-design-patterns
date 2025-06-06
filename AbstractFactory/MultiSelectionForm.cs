namespace DesignPatterns.AbstractFactory;

public class MultiSelectionForm : IForm
{
    private readonly string _title;
    public MultiSelectionForm(string title)
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
        return new List<IFormInput>
        {
            new SelectionInput("A"),
            new SelectionInput("B"),
            new SelectionInput("C"),
        };
    }

    /// <inheritdoc />
    public ICollection<IButton> CreateFormButtons()
    {
        return new List<IButton>()
        {
            new SelectAllButton(),
            new UnSelectAllButton(),
            new SaveButton(),
            new CancelButton(),
        };
    }
}
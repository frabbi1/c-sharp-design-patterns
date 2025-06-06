namespace DesignPatterns.AbstractFactory;

public class SelectionInput : IFormInput
{
    private readonly string _legend;

    public SelectionInput(string legend)
    {
        _legend = legend;
    }

    /// <inheritdoc />
    public string Legend()
    {
        return _legend;
    }

    /// <inheritdoc />
    public string Type()
    {
        return "SELECT";
    }

    /// <inheritdoc />
    public bool IsRequired()
    {
        return false;
    }
}
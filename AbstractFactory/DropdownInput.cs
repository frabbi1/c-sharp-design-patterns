namespace DesignPatterns.AbstractFactory;

public class DropdownInput : IFormInput
{
    private readonly string _legend;

    public DropdownInput(string legend)
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
        return "DROPDOWN";
    }

    /// <inheritdoc />
    public bool IsRequired()
    {
        return true;
    }

    public ICollection<string> GetDropdownMenus()
    {
        return ["abcd", "defg", "hijk"];
    }
}
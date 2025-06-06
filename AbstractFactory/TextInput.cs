namespace DesignPatterns.AbstractFactory;

public class TextInput : IFormInput
{
    private readonly string _legend;
    private readonly bool _isRequired;

    public TextInput(string legend, bool isRequired)
    {
        _legend = legend;
        _isRequired = isRequired;
    }

    /// <inheritdoc />
    public string Legend()
    {
        return this._legend;
    }

    /// <inheritdoc />
    public string Type()
    {
        return "TEXT";
    }

    /// <inheritdoc />
    public bool IsRequired()
    {
        return this._isRequired;
    }
}
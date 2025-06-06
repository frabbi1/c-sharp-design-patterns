namespace DesignPatterns.AbstractFactory;

public class SelectAllButton : IButton
{
    /// <inheritdoc />
    public string Name()
    {
        return "Select All";
    }

    /// <inheritdoc />
    public string Color()
    {
        return "Green";
    }
}
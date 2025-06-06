namespace DesignPatterns.AbstractFactory;

public class UnSelectAllButton : IButton
{
    public string Name()
    {
        return "Unselect All";
    }

    /// <inheritdoc />
    public string Color()
    {
        return "Yellow";
    }
}
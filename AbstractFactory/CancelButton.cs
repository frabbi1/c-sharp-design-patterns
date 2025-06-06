namespace DesignPatterns.AbstractFactory;

public class CancelButton : IButton
{
    /// <inheritdoc />
    public string Name()
    {
        return "Cancel";
    }

    /// <inheritdoc />
    public string Color()
    {
        return "Red";
    }
}
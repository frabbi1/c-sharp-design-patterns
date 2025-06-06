namespace DesignPatterns.AbstractFactory;

public class SaveButton : IButton
{
    /// <inheritdoc />
    public string Name()
    {
        return "SAVE";
    }

    /// <inheritdoc />
    public string Color()
    {
        return "Blue";
    }
}
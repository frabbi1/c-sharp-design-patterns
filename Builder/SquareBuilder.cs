namespace DesignPatterns.Builder;

public class SquareBuilder : IShapeBuilder
{
    private readonly Shape _shape;

    public SquareBuilder()
    {
        _shape = new Shape
        {
            Name = "Square"
        };
    }
    /// <inheritdoc />
    public IShapeBuilder AddColor(string color)
    {
        _shape.Color = color;
        return this;
    }

    /// <inheritdoc />
    public IShapeBuilder LineThickness(int thickness)
    {
        _shape.LineThickness = thickness;
        return this;
    }

    /// <inheritdoc />
    public IShapeBuilder MakeTransparent(decimal transparentLevel)
    {
        _shape.TransparentLevel = transparentLevel;
        return this;
    }

    /// <inheritdoc />
    public IShapeBuilder ScreenPosition(double xCoordinate, double yCoordinate)
    {
        _shape.XPosition = xCoordinate;
        _shape.YPosition = yCoordinate;
        return this;
    }

    /// <inheritdoc />
    public Shape Build()
    {
        return _shape;
    }
}
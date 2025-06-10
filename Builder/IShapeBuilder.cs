namespace DesignPatterns.Builder;

public interface IShapeBuilder
{
    IShapeBuilder AddColor(string color);
    IShapeBuilder LineThickness(int  thickness);
    IShapeBuilder MakeTransparent(decimal transparentLevel);
    IShapeBuilder ScreenPosition(double xCoordinate, double yCoordinate);
    Shape Build();
}
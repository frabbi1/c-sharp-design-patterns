namespace DesignPatterns.Builder;

public class ShapeCreator
{
    private readonly IShapeBuilder _builder;

    public ShapeCreator(IShapeBuilder builder)
    {
        _builder = builder;
    }

    public Shape BuildShape(string type = "Legacy")
    {
        if (type == "Legacy")
        {
            return _builder.AddColor("Red")
                .LineThickness(10)
                .MakeTransparent(0)
                .ScreenPosition(50, 50)
                .Build();
        }
        
        // modern shape
        return _builder.AddColor("Green")
            .LineThickness(8)
            .MakeTransparent(30)
            .ScreenPosition(45, 40)
            .Build();
    }
}
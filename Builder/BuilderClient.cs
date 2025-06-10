namespace DesignPatterns.Builder;

public class BuilderClient
{
    public static void Run()
    {
        var circleCreator = new ShapeCreator(new CircleBuilder());
        var moderCircle = circleCreator.BuildShape("Modern");

        var squareCreator = new ShapeCreator(new SquareBuilder());
        var legacySquare = squareCreator.BuildShape();

        ShowShape(moderCircle);
        ShowShape(legacySquare);
    }

    private static void ShowShape(Shape shape)
    {
        Console.WriteLine($"Name: {shape.Name}");
        Console.WriteLine($"Color: {shape.Color}");
        Console.WriteLine($"Line Thickness: {shape.LineThickness}");
        Console.WriteLine($"Transparency: {shape.TransparentLevel} %");
        Console.WriteLine($"Screen Position: X - {shape.XPosition}, Y - {shape.YPosition}");
        Console.WriteLine("---------------------------------");
    }
}
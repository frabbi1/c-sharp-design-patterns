namespace DesignPatterns.Builder;

public class Shape
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = "No Color";
    public decimal TransparentLevel { get; set; }
    public int LineThickness { get; set; }
    public double XPosition { get; set; }
    public double YPosition { get; set; }
}
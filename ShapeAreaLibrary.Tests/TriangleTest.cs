namespace ShapeAreaLibrary.Tests;

public class CircleTest
{
    [Fact]
    public void CalculateArea()
    {
        var circle = new Circle(new CircleParams { Radius = 3.0 });
        Assert.Equal(28.274333882308138, circle.Area());
    }
}
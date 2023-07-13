namespace ShapeAreaLibrary.Tests;

public class CircleTest
{
    [Fact]
    public void CalculateArea()
    {
        var circleParams = new CircleParams { Radius = 3.0 };
        var circle = new Circle(circleParams);
        Assert.Equal(double.Pi * circleParams.Radius * circleParams.Radius, circle.Area());
    }
}
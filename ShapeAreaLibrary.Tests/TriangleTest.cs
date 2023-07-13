namespace ShapeAreaLibrary.Tests;

public class TriangleTest
{
    [Fact]
    public void CalculateArea()
    {
        var triangleParams = new TriangleParams { FirstEdge = 3.0, SecondEdge = 4.0, ThirdEdge = 5.0 };
        var triangle = new Triangle(triangleParams);

        var p = triangleParams.FirstEdge * triangleParams.SecondEdge * triangleParams.ThirdEdge / 2.0;
        Assert.Equal(
            double.Sqrt(
                p * (p - triangleParams.FirstEdge) * (p - triangleParams.SecondEdge) * (p - triangleParams.ThirdEdge)
            ),
            triangle.Area()
        );
    }

    [Fact]
    public void IsRightTriangle()
    {
        var triangleParams = new TriangleParams { FirstEdge = 3.0, SecondEdge = 4.0, ThirdEdge = 5.0 };
        var triangle = new Triangle(triangleParams);
        Assert.True(triangle.IsRightTriangle());
    }
}
namespace ShapeAreaLibrary;

public sealed class Circle : AbstractShape
{
    private readonly CircleParams _params;

    public override double Area()
    {
        return double.Pi * _params.Radius * _params.Radius;
    }

    public Circle(CircleParams @params)
    {
        _params = @params;
    }
}
namespace ShapeAreaLibrary;

public sealed class Triangle : AbstractShape
{
    private readonly TriangleParams _params;

    public Triangle(TriangleParams @params)
    {
        _params = @params;
    }

    public override double Area()
    {
        var p = _params.FirstEdge * _params.SecondEdge * _params.ThirdEdge / 2.0;

        return double.Sqrt(p * (p - _params.FirstEdge) * (p - _params.SecondEdge) * (p - _params.ThirdEdge));
    }

    public bool IsRightTriangle()
    {
        var edges = new[] { _params.FirstEdge, _params.SecondEdge, _params.ThirdEdge };
        var hypotenuse = edges.Max();
        edges = edges.Except(new double[] { hypotenuse }).ToArray();

        return hypotenuse * hypotenuse == Array.ConvertAll(edges, x => x * x).Sum();
    }
}
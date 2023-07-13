namespace ShapeAreaLibrary;

public sealed class TriangleParams : IShapeParams
{
    public double FirstEdge { get; init; }
    public double SecondEdge { get; init; }
    public double ThirdEdge { get; init; }
}
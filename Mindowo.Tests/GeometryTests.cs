using Mindowo.Geometry;
using NUnit.Framework;

namespace Mindowo.Tests;

public class CustomSquareShape : IShape
{
    private readonly double _side;

    public CustomSquareShape(double side)
    {
        _side = side;
    }
    
    public double CalculateArea() => _side * _side;
}

[TestFixture]
public class GeometryTests
{
    [Test]
    public void CalculateCircleShapeArea_GivenRadius_ReturnsCorrectArea()
    {
        const double expectedArea = 28.27;
        
        var circle = new CircleShape(3);
        
        Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea).Within(0.01));
    }
    
    [Test]
    public void CalculateTriangleShapeArea_GivenSides_ReturnsCorrectArea()
    {
        const double expectedArea = 14.70;

        var triangle = new TriangleShape(5, 6, 7);
        
        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(0.01));
    }
    
    [Test]
    public void TriangleShapeIsRectangular_GivenSides_ReturnsTrue()
    {
        var triangle = new TriangleShape(3, 4, 5);
        
        Assert.That(triangle.IsRectangular(), Is.True);
    }
    
    [Test]
    public void CalculateCustomSquareShapeArea_GivenSide_ReturnsCorrectArea()
    {
        const double expectedArea = 25.00;

        var square = new CustomSquareShape(5);
        
        Assert.That(square.CalculateArea(), Is.EqualTo(expectedArea).Within(0.01));
    }
}
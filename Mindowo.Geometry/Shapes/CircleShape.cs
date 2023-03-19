namespace Mindowo.Geometry;

public class CircleShape : IShape
{
    private readonly double _radius;

    /// <summary>
    /// Конструктор класса круг
    /// </summary>
    /// <param name="radius">радиус круга</param>
    public CircleShape(double radius)
    {
        _radius = radius;
    }
    
    /// <summary>
    /// Вычисляет площадь круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    public double CalculateArea() => Math.PI * _radius * _radius;
}
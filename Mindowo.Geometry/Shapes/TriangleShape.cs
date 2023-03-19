namespace Mindowo.Geometry;

public class TriangleShape : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    /// <summary>
    /// Конструктор класса треугольника
    /// </summary>
    /// <param name="sideA">сторона A</param>
    /// <param name="sideB">сторона B</param>
    /// <param name="sideC">сторона C</param>
    public TriangleShape(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    /// <summary>
    /// Вычисляет площадь треугольника, используя формулу Герона
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public double CalculateArea()
    {
        var s = (_sideA + _sideB + _sideC) / 2;
        
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    public bool IsRectangular() => Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2);
}
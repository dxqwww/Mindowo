namespace Mindowo.Geometry;

/// <summary>
/// Базовый интерфейс для фигуры
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    public double CalculateArea();
}
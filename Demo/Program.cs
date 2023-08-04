using System;

// Базовый абстрактный класс для всех геометрических фигур
abstract class Shape
{
    // Методы, которые должны быть реализованы в дочерних классах
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

// Класс для круга
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Класс для квадрата
class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public override double CalculatePerimeter()
    {
        return 4 * SideLength;
    }
}

class Program
{
    static void Main()
    {
        // Пример использования классов
        Circle circle = new Circle(5);
        Console.WriteLine($"Круг с радиусом {circle.Radius}");
        Console.WriteLine($"Площадь: {circle.CalculateArea()}");
        Console.WriteLine($"Периметр: {circle.CalculatePerimeter()}");
        Console.WriteLine();

        Square square = new Square(8);
        Console.WriteLine($"Квадрат со стороной {square.SideLength}");
        Console.WriteLine($"Площадь: {square.CalculateArea()}");
        Console.WriteLine($"Периметр: {square.CalculatePerimeter()}");
        Console.WriteLine();
    }
}

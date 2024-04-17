
public class Program
{
    private static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        Console.WriteLine($"Площадь круга равна: {circle.Area()}");

        IShape triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника равна: {triangle.Area()}");
        Console.WriteLine($"Треугольник прямоугольный? {((Triangle)triangle).IsRightAngled()}");
    }
}
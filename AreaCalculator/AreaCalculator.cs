public interface IShape
{
    double Area();
}
public class Circle : IShape
{
    private double _radius;

    public Circle (double radius)
    {
        _radius = radius;
    }
    //Вычисление площади круга по радиусу
    public double Area () 
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
public class Triangle : IShape
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    //Вычисление площади треугольника по трём сторонам. Формула Герона.
    public double Area ()
    {
        double semiPerimeter = (a + b + c) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }
    //Возвращает true, если треугольник прямоугольный. Иначе false
    public bool IsRightAngled()
    {
        return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
               Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
               Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
    }
}
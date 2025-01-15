using App17;

public class Program
{
    public static void Main(string[] args)
    {
        Square shape1 = new Square(3);
        Rectangle shape2 = new Rectangle(3, 5);
        Console.WriteLine(shape1.GetPerimeter());
        Console.WriteLine(shape1.GetArea());
        Console.WriteLine(shape2.GetPerimeter());
        Console.WriteLine(shape2.GetArea());
    }
}


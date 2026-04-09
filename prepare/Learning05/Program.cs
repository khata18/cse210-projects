class Program
{
    static void Main()
    {
        List<Shape> shapes =
        [
            new Square("Red", 5),
            new Rectangle("Blue", 4, 6),
            new Circle("Green", 3),
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}

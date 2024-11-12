namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>{
            new Circle(5),
            new Rectangle(2, 5),
            new Triangle(3, 7)
};

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " area = " + shape.CalculateArea());
            }
        }
    }
}

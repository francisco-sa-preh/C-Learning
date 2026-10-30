namespace StructDistance
{
    internal class Program
    {
        public struct Point
        {
            public double X { get; }
            public double Y { get; }
            public Point(double x, double y) //construtor, não é um método normal, é aqui que acedemos a fields
            {
                X = x;
                Y = y;
            }

            public void Display() //it can also have methods
            {
                Console.WriteLine($"Point: ({X},{Y})");
            }

            public double DistanceTo(Point other)
            {
                double dx = other.X - X;
                double dy = other.Y - Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20); //inicializado aqui
            p1.Display();

            Point p2 = new Point(20, 30);

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"The distance between points is: {distance}");
        }
    }
}
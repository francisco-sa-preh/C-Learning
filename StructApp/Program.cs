namespace StructApp
{
    internal class Program
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Display() //it can also have methods
            {
                Console.WriteLine($"Point: ({X},{y})");
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20); //inicializado aqui
            p1.Display();

            Point p3 = p1;
            p3.X = 50;
            p3.Display();

        }
    }
}

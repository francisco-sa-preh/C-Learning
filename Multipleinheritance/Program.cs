namespace Multipleinheritance
{
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public class MultifunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MultifunctionPrinter printer = new MultifunctionPrinter();
            printer.Print();
            printer.Scan();
        }
    }
}

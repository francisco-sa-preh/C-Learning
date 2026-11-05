namespace DelegatesAndEvents
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }
        public void LogToFile(string message)
        {
            Console.WriteLine("File Log: " + message);
        }
    }
    internal class Program
    {

        // 1. Declaration:
        public delegate void Notify(string message); //declaring... void Notify(string message) é a signature
        // NOTA: tu podes declarar fora da class
        static void Main(string[] args)
        {
            // Delegates define method signature,
            // and any method assigned to a delegate must match this signature.

            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage; //assigning a method to the delegate that matches the method signature

            // 3. Invocation:
            notifyDelegate("Hello!");

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to clonsole");

            logHandler = logger.LogToFile;
            logHandler("Logging to file");

            Person[] people =
            {
                new Person{Name = "Alice", Age = 30},
                new Person{Name = "Bob", Age = 25},
                new Person{Name = "Charlie", Age = 35},
            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        //Generics: um método para tratar de todos os tipos de variáveis
        
        public static void PrintArray<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

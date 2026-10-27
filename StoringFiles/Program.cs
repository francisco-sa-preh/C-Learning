namespace StoringFiles
{
    public interface ILogger //"Qualquer classe que implemente ILogger tem de ter um método Log."
    {
        void Log(string message);
    }

    public class FileLogger : ILogger //"Eu implemento a interface ILogger." Polimorfismo
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt"); //combine the directory path with the filepath

            //caso não exista o directório (Logs)
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }


            File.AppendAllText(filePath, message + "\n"); //AppendAllText é um método da classe File que adiciona texto ao final de um ficheiro.
        }
    }

    public class DataBaseLogger : ILogger //"Eu implemento a interface ILogger." Polimorfismo
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database. {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger; //"Aceito qualquer objeto que implemente ILogger."

        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void DoWork()
        {
            _logger.Log("Work Started");
            //Do all the work
            _logger.Log("Work done!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DataBaseLogger();
            app = new Application(fileLogger);
            app.DoWork();


        }
    }
}

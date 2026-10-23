using System.Diagnostics;

namespace Projeto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            Debug.WriteLine("This is a debug message"); //this message will only be shown in debug mode

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()!);

                int num2 = 2;
                result = num2 / num1;
                Console.WriteLine($"The result is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This always executes"); //no matter what happens in the try block, this code will always execute
            }
        }
    }
}

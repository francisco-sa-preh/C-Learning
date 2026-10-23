using System.Diagnostics;

namespace Projeto18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.WriteLine("This is a debug message"); //this message will only be shown in debug mode

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()!);

                int num2 = 2;
                result = num2 / num1;
                Console.WriteLine($"The result is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DONT DIVIDE BY ZERO!" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                //if you want to see in the debug console, you can use Debug.WriteLine
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("This always executes"); //no matter what happens in the try block, this code will always execute
            }

            Console.WriteLine("Enter your age: ");
            GetUserAge(Console.ReadLine());

        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age) || age < 0 || age > 120)
            {
                throw new Exception("Invalid age input. Please enter a valid non-negative integer between 0 and 120.");
            }
            return age;

        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }
    }
}

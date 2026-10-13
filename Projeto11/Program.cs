namespace Projeto11 //folder
{
    class Program //file
    {
        static void Main(string[] args) //método main. Nota: O static é super importante se quiseres por o método fora do main
        {
            int myResult;






        int SubtractTwoValues(int value1, int value2)
        {
            int result = (value1 - value2);
            return result;
        }


        Console.WriteLine("Enter a number, I'll add 10 to it!");
        int num1 = int.Parse(Console.ReadLine());

        myResult = AddTwoValues(num1,10);
        Console.WriteLine("The result is " + myResult);
        Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {   
            int result = value1 + value2;
            return result;
        }
    }
}

//do while loop is a post-test loop - firstly it does then it checks if it keeps being true

int counter = 15;

do
{
    Console.WriteLine(counter);
    counter++;
} while (counter<10); //neste caso ainda executa 1 vez

//útil quando queres saber primeiro o feedback do user

int number;

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine()!);
} while (number<=0); //enquanto number não for positive whole ele irá continuar a perguntar
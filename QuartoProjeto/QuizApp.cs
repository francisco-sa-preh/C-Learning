
using System.Diagnostics.Metrics;
var counter=0;

Console.WriteLine("Question number 1: What is the capital of Germany?");
string answer1 = Console.ReadLine()!;

if(answer1.ToLower()=="berlin")
{
    Console.WriteLine("Correct!");
    counter++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("Question number 2: What is 2 + 2?");
string answer2 = Console.ReadLine()!;

if(answer2.ToLower()=="4")
{
    Console.WriteLine("Correct!");
    counter++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine("Question number 3: What do you get by mixing blue and yellow?");
string answer3 = Console.ReadLine()!;

if(answer3.ToLower()=="green")
{
    Console.WriteLine("Correct!");
    counter++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine($"You answered {counter} questions correct out of 3!");
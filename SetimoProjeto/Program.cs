int secretnumber=45;

Console.WriteLine("Guess the number!");

int usernumber=int.Parse(Console.ReadLine()!);

while(usernumber!=secretnumber)
{
    if(usernumber>secretnumber)
    {
        Console.WriteLine("Lower! Try again!");
    }

        if(usernumber<secretnumber)
    {
        Console.WriteLine("Higher! Try again!");
    }

    usernumber=int.Parse(Console.ReadLine()!);

}

Console.WriteLine($"You guessed it right! The number is {secretnumber}!");

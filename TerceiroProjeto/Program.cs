 bool isRainy = false;
 bool hasUmbrela = true;

 if(isRainy)
{
    Console.WriteLine("It's Rainy!");
}

//Logical operators && || !

//variants of or statements
//true || false = true true || true = true

if(!isRainy || hasUmbrela)
{
    Console.WriteLine("I'm not getting wet");
}

//variants of and statements
//true && true = true  true && false = false

if(isRainy && !hasUmbrela)
{
    System.Console.WriteLine("Shit, I got wet");
}


int num1 = 5;
int num2 = 6;

//Relational operators < <= > >=

bool isHigher = num1 < num2;

//equality operators == != is it equal? is it not equal?
Console.WriteLine("Número 1?");
num1=int.Parse(Console.ReadLine()!); //ReadLine lê sempre em texto (string)

Console.WriteLine("Número 2?");
num2=int.Parse(Console.ReadLine()!);

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

if(isEqual)
{
    Console.WriteLine("São iguais!");
}
else
{
    Console.WriteLine("São diferentes!");
}

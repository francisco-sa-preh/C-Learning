//métodos e classes

void MyFirstMethod()
{
    System.Console.WriteLine("My First Method!");
}

MyFirstMethod();

void WriteSomething(string mystring)
{
    Console.WriteLine("Did you say " + mystring + "?");
}

string user = "Baloni";

WriteSomething(user);

void Add2Values(int value1, int value2)
{
    int sum=value1+value2;
    Console.WriteLine($"The sum of the 2 numbers is {sum}");
}

int Add2ValuesAlternative(int value1, int value2)
{
    int sum=value1+value2;
    return sum; 
}

//se quiseres uma variável que funcione para o programa completo, logicamente, não poderá estár dentro de um método


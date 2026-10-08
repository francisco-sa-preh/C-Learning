using System.Diagnostics.CodeAnalysis;

Convertor.Test();
Console.WriteLine("Calculadora de adição:");

Console.WriteLine("Primeiro número:");
int primeiro = int.Parse(Console.ReadLine()); //readline só come strings. double.Parse para decimais 

// podes fazer a conversão em 2 passos. string input=Console.ReadLine(); int primeiro = int.Parse(input);

Console.WriteLine("Segundo número:");
int segundo = int.Parse(Console.ReadLine()!); //! elimina o warning, dá como certo ao código que não vai haver null

double soma = primeiro + segundo;
soma = Math.Round(soma,2); //para double. defines quantas casas queres arredondar

Console.WriteLine("Resultado:");
Console.WriteLine(soma); //ou, mais elegante, Console.WriteLine("Resultado: " + soma); isto é uma concatenização

//string interpolation
Console.WriteLine($"Resultado: {soma}"); //$ é importante

//explicit conversion
int myint;
double mydouble=13.5;

myint=(int)mydouble;

//se tentares de outra forma não vai funcionar. int ocupa menos espaço que double. Isto bate mal: int myint=90; double mydouble=myint;

//conversion helpers
string numberstring="30";
int result = int.Parse(numberstring);

//convert
string myboolstring="true";
bool mybool = Convert.ToBoolean(myboolstring);
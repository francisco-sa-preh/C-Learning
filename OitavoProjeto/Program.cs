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

//Average calculator
int currentScore;
int numberScores=0;
int sum=0;
int average=0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish");
    currentScore = int.Parse(Console.ReadLine()!);
    sum=sum+currentScore;

    if(currentScore != -1)
    numberScores++;

    average=sum/numberScores;

} while (currentScore!=-1);

Console.WriteLine($"The average score is {average}");

//break and continue: break salta fora do loop; continue vai para o inicio da próxima iteração (salta para o inicio do loop)

for(int i=0; i<10; i++)
{
    if(i==5)
    continue;

    Console.WriteLine("Loading..."); // esta linha é ignorada quando i=5
}


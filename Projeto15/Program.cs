namespace Projeto15;

class Program
{
    static void Main(string[] args)
    {
        /*List<string> colors = new List<string>();

        colors.Add("Red");
        colors.Add("Blue");
        colors.Add("Green");
        */
        
        List<string> colors = ["Red","Blue","Green"];

        Console.WriteLine("Current colors in the colors list!");

        foreach(string color in colors)
        {
            Console.WriteLine(color);
        }

        bool isDeletingSuccessful = colors.Remove("Red");

        while(isDeletingSuccessful)
        {
            isDeletingSuccessful = colors.Remove("Red");
        } //+

        System.Console.WriteLine(isDeletingSuccessful); 

        //new
        List<int> numbers = new List<int>{10,5,15,3,9};

        numbers.Sort(); //ordem crescente

        //Define the predicate to check if a number is greater than 10

        Predicate<int> isGreaterThanTen = x => x>=10;

        List<int> higher10 = numbers.FindAll(x => x < 10);

        //Lambda expression
        //x=> x * x "Take an input x and turn it into x multiplied by x"

        bool hasLargeNumber = numbers.Any(x=> x > 10);

        //Aula complex objects
        List<Product> products = new List<Product>
        {
            new Product{Name = "Apple", Price = 0.8}
        };

        products.Add(new Product{Name = "Berries", Price = 2.99});

        //LINQ
        List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();
    }
}

//Não é boa prática criar novas classes no mesmo ficheiro cs

public class Product
{
    //2 properties
    public string Name{get;set;}
    public double Price{get;set;}
}

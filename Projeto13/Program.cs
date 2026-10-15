namespace Projeto13;

class Program
{
    static void Main(string[] args)
    {
        //Creating an Object of the class Car or creating an instance of the Class Car
        /*Car audi = new Car("R8","Audi",false);
        Car bmw = new Car("I3","Bmw",true);

        System.Console.WriteLine("Please enter the Brand name!"); //properties in action
        audi.Brand = Console.ReadLine()!;    //this is the set part

        System.Console.WriteLine("Brand is " + audi.Brand); //this is the get part
        */

        Customer earl= new Customer("Earl");
        System.Console.WriteLine("Name of the customer "+earl.Name);

        Customer frankTheTank= new Customer("FrankTheTank", "Mainstreet 1","55512345");
        System.Console.WriteLine("Name of the customer "+frankTheTank.Name);
    }
}

namespace Projeto20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat(); //inherited method
        }
    }

    class Animal //parent class
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

    }

    //Inheritance Class dog from calss animal and has a method Bark
    class Dog: Animal //inherited class (derived or child class) dog, it has all capabilities of the parant class (f.e. Eat)
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    } //Type 1 inheritance - when there is a single inheritance

    //Type 2 inheritance - multi-level

    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts...");
        }
    }

    //Type 3 inheritance - hierarchy, one base class with other depending classes

    class Cat()
    {
        public void Miau()
        {
            Console.WriteLine("Miauing...");
        }
    }
}

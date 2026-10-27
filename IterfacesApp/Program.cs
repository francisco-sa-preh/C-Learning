namespace InterfacesApp
{

    public interface IAnimal //I from interface
    {
        void MakeSound(); //in interfaces you don't need a body
        void Eat(string food);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Treat");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("Fish");
        }
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate " + food); 
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark"); 
        }
    }
    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("cat ate " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

}

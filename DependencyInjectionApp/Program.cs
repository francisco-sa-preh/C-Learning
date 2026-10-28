namespace DependencyInjectionApp
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    public class Builder :IToolUser
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }
        private Hammer _hammer;
        private Saw _saw;
        /*
        public Builder()
        {
            _hammer = new Hammer(); //Builder is responsible for creating its dependencies //the builder is responsible for bringing his hammer (he can't work without it)
            _saw = new Saw();
        }
        

        //constructor dependency injection - the buider is given the tools
         
         public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }
        */

        //setter DI - we don't need a constructor

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House build");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();

            //Builder builder = new Builder(hammer, saw); //(DI case) 

            //setting the dependencies
            //builder.Hammer = hammer; //Injecting dependencies
            //builder.Saw = saw;

            builder.SetHammer(hammer);
            builder.SetSaw(saw);

            builder.BuildHouse();
        }
    }
}

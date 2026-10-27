namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 36, "OrderPicker", 1234); 
            joe.DisplayPersonInfo();

            Manager carl = new Manager("Carl", 45, "Manager", 2345, 7);
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        //Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person //the properties name and age are inherited from the base class
    {
        public string JobTitle { get;private set; }
        public int EmployeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID) : base(name,age) //"Quando criares um Employee, usa o construtor da classe Person que recebe name e age."
                                                               //Pensa nele como uma "ponte" para passar os valores do construtor da classe derivada para o construtor da classe base.
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee (derived class) constructor");
        }
    }

    public sealed class Manager : Employee //you can´t inherite this class, this class is final
    {
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Team size: {TeamSize}");
        }
    }
}

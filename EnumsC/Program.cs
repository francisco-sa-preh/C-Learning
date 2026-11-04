namespace EnumsC
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su}; // enums are a set of constants
    enum Month { Jan=1, Fev, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec}
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr; //index associated
            Day su = Day.Su;

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo); //index 0
            
            Console.WriteLine(Month.Jan);
            Console.WriteLine((int)Month.Jan); //it is now associated with index 1
        }
    }
}

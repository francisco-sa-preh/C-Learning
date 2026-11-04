namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);
            
            //write today on screen
            Console.WriteLine(DateTime.Today);

            //write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();

            Console.WriteLine(DateTime.Today.DayOfWeek); //chalenge: day of the week

            //Display the time in this structure x o'clock and y minutes and z seconds
            Console.WriteLine($"{DateTime.Now.Hour} o'clock and {DateTime.Now.Minute} minutes and {DateTime.Now.Second} seconds");

            //Time Passed since a given date

            DateTime now = DateTime.Now;

            Console.WriteLine("Insert a specific date: (yyyy-mm-dd)");
            string input = Console.ReadLine()!;
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"{daysPassed.Days} days passed since {dateTime}");
            }
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}

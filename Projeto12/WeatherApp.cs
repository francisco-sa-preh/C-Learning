namespace Projeto12;

class WeatherApp
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of days to simulate:");
        int days=int.Parse(Console.ReadLine()!);

        int[] temperature = new int[days]; //Note: we still don't know the number of days at this point
        string[] conditions = {"sunny","Rainy","cloudy","snowy"}; //este array dispõe as possibilidades de conditions
        string[] weatherConditions = new string[days]; //este as condições diárias

        Random random = new Random();

        for(int i=0; i<days; i++)
        {
            temperature[i] = random.Next(-10, 40);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
            System.Console.WriteLine(temperature[i] + " / " + weatherConditions[i]);
        }

        System.Console.WriteLine($"Average temperature is {averageTemperature(temperature)}!");
        System.Console.WriteLine($"The maximum temperature is {temperature.Max()} and the minimum temperature is {temperature.Min()}!");
        System.Console.WriteLine($"The most common weather condition is {mostCommonWeather(weatherConditions)}");
    }

    static double averageTemperature(int[] temperature)
    {
        double sum=0; 
        for(int i=0; i<temperature.Length;i++)
        {
            sum+=temperature[i];
        }

        double average=sum/(temperature.Length);

        return average;
    }

    static int myMaxSolution(int[] temperature)
    {
        int max = temperature[0]; //ainda melhor que definir como 0
        for(int i=0; i<temperature.Length; i++)
        {
            if(temperature[i]>max)
            {
                max=temperature[i];
            }
        }
        return max;
    }

    static string mostCommonWeather(string[] conditions)
    {
        int count=0;
        string mostCommon = conditions[0];

        for(int i=0; i<conditions.Length; i++)
        {
            int tempCount=0;
            for(int j=0; j<conditions.Length; j++)
            {
                if(conditions[i]==conditions[j])
                tempCount++;
            }
            if(tempCount>count)
            {
                count=tempCount;
                mostCommon=conditions[i];
            }

        }
        return mostCommon;
    }
    
}


public class Convertor
{
    public static void Test()
    {
        //conversion helpers
        string numberstring="30";
        int result = int.Parse(numberstring);

        //convert
        string myboolstring="true";
        bool mybool = Convert.ToBoolean(myboolstring);

        Console.WriteLine(result);
        Console.WriteLine(mybool);

        //implicitely typed variable
        var number1=13;
    }
}


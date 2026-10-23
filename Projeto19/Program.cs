namespace Projeto19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in main: ");
            }

            Console.WriteLine("E o programa continua a correr!");
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }
        /*
         * 
        Main()
         │
         │ chama
         ▼
        LevelOne()
         │
         │ chama
         ▼
        LevelTwo()
         │
         │ throw
         ▼
         EXCEPTION
         ▲
         ▲ sobe
         ▲
        LevelOne()
         ▲
         ▲ sobe
         ▲
        Main()
         │
         │ encontrou catch
         ▼
        catch
        */

        //Para evitar que o programa rebente à primeira coisa que corra mal.
    }
}

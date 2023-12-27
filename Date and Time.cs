public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        {
            Console.WriteLine("{0:T}",dt);
            Console.WriteLine("{0:D}", dt);
        }

    }
}
using System.ComponentModel;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any number:");
        int number=Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine(number+"x"+i+"="+ number*i);
            i++;
        }

    }
}

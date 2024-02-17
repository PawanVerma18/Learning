using ConsoleApp44;

public class Program
{
    public static void Main(string[] args)
    {
        TemperatureConverter converter = new TemperatureConverter();
        Console.WriteLine("Choose the Option you want to convert temperature from:");
        Console.WriteLine("Enter 1 for Celsius to Fahrenheit:");
        Console.WriteLine("Enter 2 for Fahrenheit to Celsius:");
        int input = Convert.ToInt32(Console.ReadLine());

        if(input == 1)
        {
            Console.WriteLine("Enter your Temperature in Celcius:");
            double temp = Convert.ToDouble(Console.ReadLine());
            converter.CtoF(temp);
        }

        else if(input == 2)
        {
            Console.WriteLine("Enter your Temperature in Fahrenheit:");
            double tepm=Convert.ToDouble(Console.ReadLine());
            converter.FtoC(tepm);
        }
  



    }
}
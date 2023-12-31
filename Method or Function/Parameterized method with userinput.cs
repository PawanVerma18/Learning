using System.Reflection.Metadata.Ecma335;

public class program
{
    public static void Add(int num1,int num2) // parameterized method
    {
        int sum = num1 + num2;
        Console.WriteLine("The sum is:" +sum);
    }
    public static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            program.Add(a, b);
            Console.WriteLine("Do you want to restart your program:" + "Yes/No");
            string c = Console.ReadLine().ToLower();

            if (c == "yes")
            {
                continue;
            }

            else
            {
                break;
            }

        }
        



       


    }
}
using System.Reflection.Metadata.Ecma335;

public class Learning
{
    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            int multiply = num1 * num2;
            Console.WriteLine("The multiplication is:" + multiply);
            Console.WriteLine("Do you want to restart your program:" + "Yes/No");
            string userinput = Console.ReadLine().ToLower();
            if (userinput == "yes")
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


public class Learning
{
    public static void Main(string[] args)
    {
        string userinput;
        do
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The Sum is:" + sum);
            Console.WriteLine("Do you want to restart your program:" + "Yes/No");
            userinput = Console.ReadLine().ToLower();
        }
        while (userinput == "yes");
    }

}
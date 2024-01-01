public class Program
{
    public static void Addition(int x, int y)
    {
        int resultA = x + y;
        Console.WriteLine("Addition result is: {0}",resultA);
    }
    public static void Subtraction(int x, int y)
    {
        int resultS = x - y;
        Console.WriteLine("Subtraction result is: {0}", resultS);
    }

    public static void Multiplication(int x, int y)
    {
        int resultM = x * y;
        Console.WriteLine("Multiplication result is: {0}", resultM);
    }

    public static void Division(int x, int y)
    {
        int resultD = x / y;
        Console.WriteLine("Division result is: {0}", resultD);
    }


    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator:" + "(+,-,*,/)");
            string OP = Console.ReadLine();
           

            if (OP.Equals("+"))
            {
                Program.Addition(num1, num2);
            }
            else if (OP.Equals("-"))
            {
                Program.Subtraction(num1, num2);
            }
            else if (OP.Equals("*"))
            {
                Program.Multiplication(num1, num2);
            }
            else if (OP.Equals("/"))
            {
                Program.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invaliod Operator!");
            }
            Console.WriteLine("Do you want to restart your program?"+"Yes/No");
            string restart=Console.ReadLine().ToLower();

            if (restart.Equals("yes"))
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
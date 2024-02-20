public class Program
{
    public static bool PrintPrimeNum(int x)
    {
        if (x <= 1) return false;
        if (x == 2 || x == 3) return true;
        if (x % 2 == 0 || x % 3 == 0) return false;

        int i = 5;
        while (i * i <= x)
        {
            if (x % i == 0 || x * (i + 2) == 0)
                return false;
            i = i + 6;
        }
        return true;
    }

        public static bool IsPrime(int x)
    {
        if (x <= 1) return false;
        if(x==2 ||  x==3) return true;
        if (x % 2 == 0 || x % 3 == 0) return false;

        int i = 5;
        while (i * i <= x)
        {
            if(x%i==0 || x%(i+2) == 0)
                return false;
            i = i + 6;
        }
        return true;

    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a range:");
        Console.Write("From:");
        int a =Convert.ToInt32(Console.ReadLine());
        Console.Write("TO:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Prime Numbers between {a} and {b} are:");
        
        
            for(int x = a; x < b; x++)
            {
               if (PrintPrimeNum(x))
                Console.Write(x + " ");   

            }
                
        
        Console.WriteLine();

        Console.Write("Enter a number to check is it is prime number or not:");

        int c = Convert.ToInt32(Console.ReadLine());
        bool z =IsPrime(c);
        Console.WriteLine(z);


    }
}
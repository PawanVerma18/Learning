using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;

public class Pawan
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any number:");
        int x=Convert.ToInt32(Console.ReadLine());
        int i = 1;
        do
        {
            Console.WriteLine(i*x);
            i++;
        }
        while (i<=10);
    }
}
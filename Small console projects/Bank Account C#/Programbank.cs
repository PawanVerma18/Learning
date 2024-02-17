using ConsoleApp41;


public class Program
{
    public static void Main(string[] args)
    {
        BankAccount p1 = new BankAccount();
        p1.deposit(3001);
        p1.withdrawal(1000);
        p1.deposit(102);
       

        Console.WriteLine($"Final Balance is:{p1.AccountBalance}");


    }
}
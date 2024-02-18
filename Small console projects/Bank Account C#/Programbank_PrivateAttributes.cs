using ConsoleApp46;

public class program
{
    public static void Main(string[] args)
    {
        BankAccount a1 = new BankAccount("45493000180", 2000);
        Console.WriteLine($"AccounNumber:{a1.GetAccountNumber()} has {a1.GetBalance()} total balance!");

        a1.deposit(1000);
        Console.WriteLine($"AccounNumber:{a1.GetAccountNumber()} has {a1.GetBalance()} total balance!");

        a1.withdrawal(34500);
        Console.WriteLine($"AccounNumber:{a1.GetAccountNumber()} has {a1.GetBalance()} total balance!");
    }
}
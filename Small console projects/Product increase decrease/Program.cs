using ConsoleApp43;

public class Program
{
    public static void Main(string[] args)
    {
        Product p1= new Product("Rice",500,1200);
        p1.PrintDetails();

        Console.WriteLine();

        p1.Increase(800);
        p1.Decrease(500);


        Console.WriteLine("Final StockQuantity:"+p1.StockQuantity);

    } 
}
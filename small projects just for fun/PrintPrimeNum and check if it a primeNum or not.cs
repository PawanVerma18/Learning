public class Program
{
    
    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        int sum =0;
        Console.WriteLine("Enter your data:");
        for (int i = 0; i <= 10; i++)
        {
           int data = Convert.ToInt32(Console.ReadLine());
            numbers[i] = data;
            sum = sum + data;
        }
        Console.Write("Your Data:");
        foreach (int value in numbers)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine("Sum:"+sum);
    }
}
using System.Runtime.InteropServices;

public class program
{
    public static void Main(String[] args)
    {
        const int maxsize = 10000;
        int[] numbers = new int[maxsize];
        int evenSum = 0;
        int oddCount = 0;
        int count = 0;
        Console.WriteLine("Enter your data: (Enter -1 to eliminate!)");

        while (count < maxsize)
        {
            int data= Convert.ToInt32(Console.ReadLine());
            if (data == -1)
                break;

            if (data >= 0)
            {
                numbers[count] = data;
                count++;


                if (data % 2 == 0)
                {
                    evenSum = evenSum + data;

                }

                else
                {
                    oddCount++;
                }
            }
            else
            {
                Console.WriteLine("Negative number is ignored!");
            }
        }

        Console.Write("Entered numbers are:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.Write("\nEvensum:");
        Console.Write(evenSum);
        Console.Write("\nOddCount:");
        Console.Write(oddCount);
    }
}
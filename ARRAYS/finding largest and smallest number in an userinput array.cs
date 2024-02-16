using System.Diagnostics.Metrics;

public class program
{
    public static void Main(string[] args)
    {
        const int maxsize = 10000;
        int[] numbers = new int[maxsize];
        int count = 0;
        int largest = int.MinValue;
        int smallest= int.MaxValue;

        Console.WriteLine("Enter your numbers: (Enter -1 to terminate!)");

        int userinput;
        while((userinput = Convert.ToInt32(Console.ReadLine())) != -1 && count<maxsize)
        {
            if(userinput>=0)
            {
                if (userinput > largest)

                    largest = userinput;


                if (userinput < smallest)

                    smallest = userinput;

                numbers[count] = userinput;
                count++;
            }
            else
            {
                Console.WriteLine("Negative number ignored!");
            }


        }

        Console.Write("\nEntered numbers are:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"\nTotal numbers entered:"+ count);
        Console.WriteLine($"\nLargest number:"+largest);
        Console.WriteLine($"\nSmallest number:"+smallest);


    }
}

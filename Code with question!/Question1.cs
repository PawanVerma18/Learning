using System.ComponentModel;
using System.Globalization;

//Write a program that prompts the user to enter a set of numbers terminated by -1. The program must then print all the numbers entered by the user at the end of the program and then print the number of numbers entered by the user and the largest and smallest number within the set. Program should store all the numbers in an array called numbers. 
//Hints: Assume there are at most 10,000 numbers entered

public class Array
{
    
    public static void Main(string[] args)
    {
        const int maxsize = 10000;
        int[] numbers = new int[maxsize];
        int count = 0;
        int largestvalue = int.MinValue;
        int smallestvalue = int.MaxValue;

        Console.WriteLine("Enter your data: (Enter -1 to eliminate!)");

        while (count < maxsize)
        {
            int data = Convert.ToInt32(Console.ReadLine());

            if (data == -1)
            {
                break;
            }

            if (data >= 0)
            {
                numbers[count] = data;
                count++;

                if (largestvalue < data)
                {
                    largestvalue = data;
                }

                if (smallestvalue > data)
                {
                    smallestvalue = data;
                }

            }
            else
            {
                Console.WriteLine("Negative numnber ignored!");
            }


        }

        Console.Write("\nYour data:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.Write("\nTotal number entered:"+count);

        Console.Write("\nLagest number:" + largestvalue);
        Console.Write("\nSmallest number:"+smallestvalue);
    }
}
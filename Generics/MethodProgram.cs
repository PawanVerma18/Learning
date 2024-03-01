using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    public class Details()
    {
        public static void ShowArray<T>(T[] array)
        {
            Console.Write("Your Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0;i < array.Length;i++)
            {
                sum += array[i];
            }
            return sum;
            
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many values you want in your array?");
            int value = Convert.ToInt32(Console.ReadLine());
            if(value > 0)
            {
                int[] numbers = new int[value];
                Console.WriteLine("\nOkay,now enter your numbers:");
                for (int i = 0; i < value; i++)
                {
                    Console.Write($"\nEnter data at position {i}: " );
                    int data = Convert.ToInt32(Console.ReadLine());
                    if(data > 0)
                    {
                        numbers[i] = data;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number greater than zero!");
                        i--;
                    }



                }


                Console.WriteLine();
                Details.ShowArray(numbers);

                int sum = Details.SumArray(numbers);
                Console.Write("\nSum of Array: " + sum);

            }
            else
            {
                Console.WriteLine("Please enter number greater than Zero to initiate Program!");
            }

            
        }
    }
}

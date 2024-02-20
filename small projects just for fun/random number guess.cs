using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);

            Console.WriteLine("Enter Your Number between 1 and 6:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= 6)
            {
                Console.WriteLine("Program terminatede! Entered number is greater than 5!");
                break;

            }
            else if (input <= 0)
            {
                Console.WriteLine("Program terminated! Entered number is less than 1!");
                break;
            }


            if (input == num)
            {
                Console.WriteLine("Wow, your guess is Right!");
            }
            else
            {
                Console.WriteLine("Sorry, your guess is Wrong!");
            }

            Console.WriteLine("Random Number Was: " + num);

            Console.WriteLine("Do you want to restart your program? + Y/N");
            string restart = Console.ReadLine().ToLower();
            
            
            
                if (restart != "y" && restart != "n")
                {
                    Console.WriteLine("Invalid Option!");
                    break;
                }

                else if (restart == "n")
                {
                    Console.WriteLine("Program terminated!");
                    break;

                }
                else
                {
                    continue;
                }

            
            


        }
    }
}

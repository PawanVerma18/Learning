using System.Diagnostics.Contracts;
using System.Threading.Channels;

namespace ConsoleApp55
{
    public class Student
    {

        private int[] age;
        public Student(int x)
        {
            age = new int[x];
        }

        public int this[int index]
        {
            set
            {
                if(value > 0)
                {
                    if(index>=0 && index < age.Length) 
                    {
                        age[index] = value;

                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Out of Index!");
                    }
                }
                else
                {
                    throw new Exception("Negative or Zero Age is not possible!");
           
                }

            }
            get
            {
                if(index >= 0 && index < age.Length)
                {
                    return age[index];
                }
                else
                {
                    throw new Exception("Out Of Index!");
                }

            }
        }

        
        
    }

    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many index you want?");
            int x = Convert.ToInt32(Console.ReadLine());
            Student s = new Student(x);

            for (int i = 0; i < x; i++)
            {
                try
                {
                    Console.WriteLine($"Enter value at: {i}");
                    int y = Convert.ToInt32(Console.ReadLine());
                    s[i]= y;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error Occured:"+ e.Message);
                    i--;
                }
            }

            Console.Write("\nYour Index:");

            for (int i = 0; i<x; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();



        }
    }
}

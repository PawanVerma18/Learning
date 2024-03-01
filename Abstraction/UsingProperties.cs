using System;
namespace ConsoleApp57
{
    abstract class Person
    {
        public abstract int id { get; set; }
        public abstract string name { get; set; }
    }

    class Student : Person
    {
        private int Stdid;
        private string Stdname;

        public override int id
        {
            set
            {
                if(value > 0)
                {
                    this.Stdid = value;

                }
                else
                {
                    throw new Exception(" Invalid Id!");
                }
            }

            get
            {
                return this.Stdid;
            }
        }

        public override string name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception(" Name Cannot be Null!");

                }
                else
                {
                   this.Stdname = value;
                }
            }

            get
            {
                return this.Stdname;

            }
        }
     

    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            

            try
            {
                s1.id = 1;
                s1.name = "Pawan";
                Console.WriteLine("ID: " + s1.id);
                Console.WriteLine("Name: " + s1.name);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured:" + e.Message);
            }
        }
    }
}

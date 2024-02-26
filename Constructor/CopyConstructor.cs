using System.Runtime.InteropServices.Marshalling;

namespace CopyConstructor
{
    class Person
    {
        public  int Age;
        public string Name;

        public Person(int a,string n)
        {
            Age = a;
            Name = n;
        }

        public void details()
        {
            Console.WriteLine("Name is:"+Name);
            Console.WriteLine("Age is:"+ Age);
        }

        public Person(Person p) //copy constructor
        {
            Age = p.Age;
            Name = p.Name;
        }

       

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(21,"Pawan");
            Person p2 = new Person(p1);
            p1.details();
            Console.WriteLine();
            p2.details();   

        }
    }
}

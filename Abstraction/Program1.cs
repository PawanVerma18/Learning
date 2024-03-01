using System.ComponentModel;
using System.Xml.Linq;

namespace ConsoleApp56
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public long PhoneNo;

        public abstract void Show();


    }

    class Student : Person
    {
        public int RollNo;
        public int Fees;

        public override void Show()
        {
            string Name = this.FirstName + " " + this.LastName;
            Console.WriteLine("----------Student Details Are---------");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + this.age);
            Console.WriteLine("PhoneNo:"+ this.PhoneNo);
            Console.WriteLine("RollNo:"+ this.RollNo);
            Console.WriteLine("Fees:"+this.Fees);

        }
    }

    class Teacher : Person 
    {
        public string Qualification;
        public int salary;

        public override void Show()
        {
            string Name = this.FirstName + " " + this.LastName; 
            Console.WriteLine("----------Teacher Details Are----------");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + this.age);
            Console.WriteLine("PhoneNo:" + this.PhoneNo);
            Console.WriteLine("Qualification:" + this.Qualification);
            Console.WriteLine("Salary:" + this.salary);


        }
    }
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Pawan";
            s1.LastName = "Verma";
            s1.age = 21;
            s1.PhoneNo = 4375561538;
            s1.RollNo = 27;
            s1.Fees = 6000;   
            
            s1.Show();

            Console.WriteLine();

            Teacher t1 = new Teacher();
            t1.FirstName = "Anil";
            t1.LastName = "Singh";
            t1.age = 40;
            t1.PhoneNo = 9140298218;
            t1.Qualification = "Phd in Physics";
            t1.salary = 90000;

            t1.Show();


        }
    }

}

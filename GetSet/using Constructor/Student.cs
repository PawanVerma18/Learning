using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Student
    {
        string name;
        int standard;
        string section;


        public Student(string name, int standard, string section)
        {
            this.name = name;
            this.standard = standard;
            this.section = section;
        }

        public string getname()
        {
            return name;
        }
        public int getstandard()
        {
            return standard;    
        }
        public string getsection()
        {
            return section;
        }

        public void setname(string name)
        {
            Console.WriteLine("Name:"+this.name);
        }

        public void setstandard(int standard)
        {
            Console.WriteLine("Standard:" + this.standard);

        }

        public void setsection(string section)
        {
            Console.WriteLine("Section:"+ this.section);
        }
    }

}

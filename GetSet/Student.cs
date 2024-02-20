using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    public class Student
    {
        string Name;
        int Standard;
        string Section;
        int RollNo;

        public void setStudent(string n, int s, string S, int r)
        {
            Name = n;
            Standard = s;
            Section = S;
            RollNo = r;

        }

        public void getStudent()
        {
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Standard:"+Standard);
            Console.WriteLine("Section:" + Section);
            Console.WriteLine("Roll No:"+RollNo);
        }
       
    }

    
}

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Pawan",12,"A");
            s1.setname("Pawan");
            s1.setstandard(12);
            s1.setsection("B");

            Console.WriteLine();

            Console.WriteLine("Standard is:"+s1.getstandard());



        }
    }
}
namespace ConsoleApp58
{
    interface Animal1
    {
        void show1();
    }

    interface Animal2
    {
        void show2();
    }

    interface Animal3 : Animal1, Animal2
    {
        void show3();
    }

    public class Deatails : Animal3
    {
        public void show1()
        {
            Console.WriteLine("Dog");
        }

        public void show2()
        {
            Console.WriteLine("Elephant");
        }

        public void show3()
        {
            Console.WriteLine("Tiger");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Deatails D = new Deatails();
            D.show1();
            D.show2();
            D.show3();
        }
    }
}

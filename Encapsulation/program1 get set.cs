namespace AccessSpecifiers1
{
    public class Person
    {
        private string name;
        private int age;

        public void setdetails(string n,int a)
        {
            if (string.IsNullOrEmpty(n)==true)
            {
                Console.WriteLine("Name cannot be empty!");
            }
            else
            {
                name  = n;
            }

            if (a> 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Age cannot be Negative or Zero!");
            }
        }
        public void getdetails()
        {
            if (string.IsNullOrEmpty(name) == true)
            {
               
            }
            else
            {
                Console.WriteLine("Name is:"+name);
            }

            if(age > 0)
            {
                Console.WriteLine("Age is:"+age);
            }
            else
            {

            }
            

        }



    }
    
    public class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Console.WriteLine("Enter your name:");
            string x = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int y = Convert.ToInt32(Console.ReadLine());
            p1.setdetails(x,y);
            p1.getdetails();
            
        }

    }
}

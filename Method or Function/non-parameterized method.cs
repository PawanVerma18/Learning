public class program
{
    public void Show() //declaration //non-static method or instance method // non-parameterized method
    {
        Console.WriteLine("Hey buddy..");
        Console.WriteLine("sam...");
    }
    
    public static void Show1()
    {
        Console.WriteLine("Hello Pawan..");
        Console.WriteLine("Hii Shiv");
    }


    public static void Main(string[] args)
    {
        program p1 = new program(); //object
        p1.Show();     // calling function by object


        program.Show1(); //calling function by class

    }
}
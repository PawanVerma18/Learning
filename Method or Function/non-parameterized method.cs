public class program
{
    public void Show1() //declaration //non-static method or instance method // non-parameterized method
    {
        Console.WriteLine("Hey buddy..");
        Console.WriteLine("sam...");
    }
    
    public static void Show2()
    {
        Console.WriteLine("Hello Pawan..");
        Console.WriteLine("Hii Shiv");
    }


    public static void Main(string[] args)
    {
        program p1 = new program(); //object
        p1.Show1();     // calling function by object


                program.Show2(); //calling function by class
    }
}
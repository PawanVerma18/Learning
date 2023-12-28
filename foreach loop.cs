public class program
{
    public static void Main(string[] args)
    {
        //int data type

        int[] numbers = { 1, 23, 67, 989, 74, 36 };
        foreach(int item in numbers)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("------------------------");


        //  String data type

        string[] names = new string[] { "Pawan", "Sam", "krishna", "sahil", "yash" };
        foreach(string item in names)
        {
            Console.WriteLine(item);
        }
    }
}
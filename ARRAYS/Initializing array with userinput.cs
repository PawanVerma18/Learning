public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many numbers you want in your array:");
        int num=Convert.ToInt32(Console.ReadLine());
        int[] items = new int[num];
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter data at location:"+(i+1));
            int data=Convert.ToInt32(Console.ReadLine());
            items[i] = data;
        }
        Console.WriteLine("-----------Your Data------------");
        foreach (int value in items)
        {
            Console.Write(value + " ");
        }
    }
}
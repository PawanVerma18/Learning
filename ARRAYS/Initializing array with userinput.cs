public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many numbers you want in your data?");
        int num=int.Parse(Console.ReadLine());
        int[] items=new int[num];
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter data at location:"+i);
            int data=int.Parse(Console.ReadLine());
            items[i]=data;
        }
        Console.WriteLine("----------Your Data-----------");
        foreach(int value in items)
        {
            Console.WriteLine(value); 
        }
    }   

}
public class program
{
    public static void Main(string[] args)
    {
        int[][] numbers = new int[3][];
        numbers[0] = new[] { 1, 2, 25, 56 };
        numbers[1] = new[] { 3, 2, 15, 56 };
        numbers[2] = new[] { 2, 2, 45, 67 };
        foreach (int[] items in numbers)
        {
            foreach(int i in items)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

}
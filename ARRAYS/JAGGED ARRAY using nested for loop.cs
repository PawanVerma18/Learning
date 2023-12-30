public class program
{
    public static void Main(string[] args)
    {
        int[][] numbers = new int[3][];
        numbers[0] = new[] { 1, 2, 3 };
        numbers[1] = new[] { 12, 31, 45, 56, 56 };
        numbers[2] = new[] { 12, 33, 21, 32, 43, 43, 98, 99 };
        for(int i = 0; i < numbers.GetLength(0); i++)
        {
            for(int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }
            Console.WriteLine();

        }

   }
}
using System;
using System.Threading.Channels;
using System.Xml;

public class program
{
    public static void Main(string[] args)
    {
        int[,] array = new int[3, 4]
        {
            {10,22,31,45},
            {11,23,42,96},
            {12,24,34,76}
           
        };

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");

            Console.WriteLine();
        }
        


    }
}
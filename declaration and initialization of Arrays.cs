using System.Net.NetworkInformation;

public class arrays
{
    public static void Main(string[] args)
    {
        //Type 1

        string[] my_array1 = { "Krishna", "Yash", "John", "sam" };

        {
            Console.WriteLine(my_array1[3]);
        }


        //Type 2

        string[] my_array2 = new string[] { "Krishna", "Pawan", "Sam", "Sahil" };
        {
            Console.WriteLine(my_array2[0]);
        }



        //Type 3

        string[] my_array3 = new string[4];
        my_array3[0] = "Pawan";
        my_array3[1] = "sam";
        my_array3[2] = "krishna";
        my_array3[3] = "sahil";
        {
            Console.WriteLine(my_array3[0]);
        }
    }
}
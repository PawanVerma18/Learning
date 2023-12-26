using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        // Loop from 0 to 10
        for (int i = 0; i <= 10; i++)
        {
            // Check if i is equal to 5
            if (i == 5)
                // Jump to the label "Stop" if i is equal to 5
                goto Stop;

            // Print the current value of i
            Console.WriteLine(i);
        }

        // This block will be ignored because of the goto statement
        {
            Console.WriteLine("loop terminates..");
        }

    // Label indicating where the goto statement will jump
    Stop:
        {
            // Print this message when the program encounters the "Stop" label
            Console.WriteLine("program exits..");
        }
    }
}

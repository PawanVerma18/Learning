public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your full name::");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Your ROll Number:");
        int roll_number=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Your Standard");
        int standard=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Hindi Marks:");
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter English Marks:");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Maths Marks:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter physics Marks:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Chemistry Marks:");
        int c = int.Parse(Console.ReadLine());

        int obt=h + e+ m + p + c;
        float per = obt * 100 / 500f;
        {
            Console.WriteLine("-------Marksheet-------");
            Console.WriteLine("Your Name is:{0}",name);
            Console.WriteLine("Your Roll number is:{0}",roll_number);
            Console.WriteLine("Your Standard is:{0}",standard);
            Console.WriteLine("Your Obtained marks are:{0}",obt);
            Console.WriteLine("Your Percentage is:{0}",per);
        }

        if (per >= 80)
        {
            Console.WriteLine("Grade:A1");
        }
        else if (per >= 70)
        {
            Console.WriteLine("Grade:A");
        }
        else if (per >= 60)
        {
            Console.WriteLine("Grade:B");
        }
        else if (per >= 50)
        {
            Console.WriteLine("Grade:C");
        }
        else if (per >= 33)
        {
            Console.WriteLine("Grade:E");
        }
        else
        {
            Console.WriteLine("Grade:F(Fail)");
        }
        //remarks
        if (per >= 80)
        {
            Console.WriteLine("Remarks:Excellent..");
        }
        else if (per >= 70)
        {
            Console.WriteLine("Remarks:Very good..");
        }
        else if (per >= 60)
        {
            Console.WriteLine("Remarks:Good..");
        }
        else if (per >= 50)
        {
            Console.WriteLine("Remarks:Fair..");
        }
        else if (per >= 33)
        {
            Console.WriteLine("Remarks:Needs improvement..");
        }
        else
        {
            Console.WriteLine("Remarks:Bring your Parents Tomorrow..");
        }
        //h + e+ m + p + c;
        int back = 0;
        if (h < 33)
        {
            Console.WriteLine("You are failed in Hindi..");
            back++;
        }
        if (e < 33)
        {
            Console.WriteLine("You are failed in English..");
            back++;
        }
        if (m < 33)
        {
            Console.WriteLine("You are failed in Maths..");
            back++;
        }
        if (p < 33)
        {
            Console.WriteLine("You are failed in Physics..");
            back++;
        }
        if (c < 33)
        {
            Console.WriteLine("You are failed in Chemistry..");
            back++;
        }
        {
            Console.WriteLine("You are failed in {0} subjects",back);
        }

















    }
}
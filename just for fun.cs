public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Pizza Type:");
        string pizza=Console.ReadLine();

        switch (pizza)
        {
            case "veg":
                {
                    Console.WriteLine("You have selected veg pizza..");
                    Console.WriteLine("Whiuch type of vegetables you want:");
                    string s=Console.ReadLine();

                    switch (s)
                    {
                        case "tomato":
                            {
                                Console.WriteLine("You have selected tomato pizza..");
                                break;
                            }
                        case "olives":
                            {
                                Console.WriteLine("You have selected olives pizzza..");
                                Console.WriteLine("please suggest which olive you want:");
                                string o=Console.ReadLine();

                                switch (o)
                                {
                                    case "Black Olives":
                                        {
                                            Console.WriteLine("Youn have selected Black Olives..");
                                            break;
                                        }
                                    case "Green Olives":
                                        {
                                            Console.WriteLine("You have selected Green Olives..");
                                            break;
                                        }

                                }
                                break;
                            }

                    }
                    break;
                }
            case "cheese":
                {
                    Console.WriteLine("You have selected cheese pizza..");
                    break;
                }
            case "simple":
                {
                    Console.WriteLine("You have selected simple pizza");
                    break;
                }
            default:
                {
                    Console.WriteLine("Sorry,this type of pizza is not available");
                    break;
                }
                   

        }

    }
}
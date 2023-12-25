public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Pizza Type:");
        string pizza = Console.ReadLine();

        switch (pizza)
        {
            case "Veg":
                {
                    Console.WriteLine("You have selected veg pizza..");
                    Console.WriteLine("Which type of vegetables you want:");
                    string s = Console.ReadLine();

                    switch (s)
                    {
                        case "Tomato ":
                            {
                                Console.WriteLine("You have selected tomato veg pizza..");
                                break;
                            }
                        case "Olive":
                            {
                                Console.WriteLine("You have selected olive veg pizza..");
                                Console.WriteLine("please suggest which olive you want:");
                                string o = Console.ReadLine();

                                switch (o)
                                {
                                    case "Black":
                                        {
                                            Console.WriteLine("You have selected black olive veg pizza..");
                                            break;
                                        }
                                    case "Green":
                                        {
                                            Console.WriteLine("You have selected green olive veg pizza..");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Sorry,this type of olive is not available..");
                                            break;
                                        }
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Sorry,this type of veg pizza is not available..");
                                break;
                            }

                    }
                    break;
                }
            case "Cheese":
                {
                    Console.WriteLine("You have selected cheese pizza..");
                    break;
                }
            case "Simple":
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
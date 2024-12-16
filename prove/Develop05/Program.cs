using System;

namespace MindfulApp
{

class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();
                Activity activity = null;

                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        return;
                    default:
                        Console.WriteLine("Wrong choice. Try again.");
                        continue;
                }

                activity.Run();

            }
        }
    }
}

// i used chatgpt as reference
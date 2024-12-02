using System;

public class Program
{
    public static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words at a time
        }
    }
}

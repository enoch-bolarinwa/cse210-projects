 class ListingActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by listing items in a specific area.") { }

        public override void Run()
        {
            StartMessage();
            int duration = GetDuration();

            Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
            PauseWithSpinner(3, "Prepare to list");

            int itemCount = 0;
            Console.WriteLine("Start listing items. Press Enter after each item.");

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"\nYou listed {itemCount} items!");
            EndMessage();
        }
    }
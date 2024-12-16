 
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", 
            "This activity will help you relax by guiding you through breathing in and out slowly.") { }

        public override void Run()
        {
            StartMessage();
            int duration = GetDuration();

            while (duration > 0)
            {
                Console.WriteLine("Breathe in...");
                PauseWithSpinner(2, "Breathing");
                duration -= 2;

                Console.WriteLine("Breathe out...");
                PauseWithSpinner(2, "Breathing");
                duration -= 2;
            }

            EndMessage();
        }
    }
// Reflection Activity
    class ReflectionActivity : Activity
    {
        private static readonly string[] Prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly string[] Questions = {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel when it was complete?",
            "How can you apply this experience to other situations?"
        };

        public ReflectionActivity() : base("Reflection Activity",
            "This activity will help you reflect on times in your life when you showed strength and resilience.") { }

        public override void Run()
        {
            StartMessage();
            int duration = GetDuration();

            Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
            PauseWithSpinner(3, "Reflecting");

            while (duration > 0)
            {
                Console.WriteLine(Questions[new Random().Next(Questions.Length)]);
                PauseWithSpinner(5, "Thinking");
                duration -= 5;
            }

            EndMessage();
        }
    }
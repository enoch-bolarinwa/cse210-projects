using System;

    abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void StartMessage()
        {
            Console.WriteLine($"Welcome to the {_name}!");
            Console.WriteLine(_description);
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to start...\n");
            PauseWithSpinner(3, "Getting ready");
        }

        public void EndMessage()
        {
            Console.WriteLine("\nGreat job!");
            PauseWithSpinner(3, "Finalizing");
            Console.WriteLine($"You completed the {_name} for {_duration} seconds.\n");
        }

        protected int GetDuration() => _duration;

        protected void PauseWithSpinner(int seconds, string message)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write($"\r{message}{new string('.', i + 1)}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");
        }

        public abstract void Run();
    }

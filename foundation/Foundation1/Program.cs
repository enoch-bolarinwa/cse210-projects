using System;


class Program
    {
        static void Main(string[] args)
        {
            // Create some videos
            var video1 = new Video("Introduction to C#", "John Doe", 600);
            var video2 = new Video("Understanding LINQ", "Jane Smith", 900);
            var video3 = new Video("Advanced C# Techniques", "Sarah Johnson", 1200);

            // Add comments to each video
            video1.AddComment(new Comment("Alice", "Great explanation!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Can you make a video on async/await?"));

            video2.AddComment(new Comment("Dave", "This cleared up my confusion about LINQ."));
            video2.AddComment(new Comment("Eve", "Fantastic tutorial!"));
            video2.AddComment(new Comment("Frank", "Could you provide more examples?"));

            video3.AddComment(new Comment("Grace", "This is so advanced but great content!"));
            video3.AddComment(new Comment("Hannah", "I learned so much from this video."));
            video3.AddComment(new Comment("Ivy", "Can you make a series on design patterns?"));

            // Add videos to a list
            var videos = new List<Video> { video1, video2, video3 };

            // Iterate through the list and display the details of each video
            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }

                Console.WriteLine();
            }
        }
    }

using System;

class Program
    {
        static void Main(string[] args)
        {
            var video3 = new Video ("You Got Time", "Dunsin Oyekan", 3000);
            var video2 = new Video ("In His Presence", "Bidemi Olaoba", 1500);
            var video1 = new Video ("Mori Anu Gba", "Tolucci", 1700);

            video3.AddComment(new Comment ("Femi Rotimi", "The song ministered to me greatly. More grace"));
            video2.AddComment(new Comment ("Dele Ojo", "The yearly concert is a blessing to Christendom."));
            video1.AddComment(new Comment ("Ayomikun Temitope", "I have truly obtained mercies."));

            video3.AddComment(new Comment ("Imole Esther", "The lyrics are captivating."));
            video2.AddComment(new Comment ("Tope Deborah", "May you continue to be a vessel in God's hand"));
            video1.AddComment(new Comment ("Shade Lukmon", "Mercy can truly break protocol"));

            video3.AddComment(new Comment ("Segun Farinto", "I like the lyrics that say he got time and season in His hands."));
            video2.AddComment(new Comment ("Seyi Adewale", "The hymns are powerful. More fire on your altar"));
            video1.AddComment(new Comment ("Tomiwa Tosin", "The Instrumentation was perfect."));

            var videos = new List<Video> {video3, video2, video1};

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.DurationInSeconds} seconds");
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

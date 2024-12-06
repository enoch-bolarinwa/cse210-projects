using System;

class Program
    {
        static void Main(string[] args)
        {
            
            var video03 = Video ("You Got Time", "Dunsin Oyekan", 1800);
            var video02 = Video ("In His Presence", "Bidemi Olaoba", 1200);
            var video01 = Video ("Mori Anu Gba", "Tolucci", 1200);

            Video03.AddComment(Comment ("Femi Rotimi", "The song ministered to me greatly. More grace"));
            Video02.AddComment(Comment ("Dele Ojo", "The yearly concert is a blessing to Christendom."));
            Video01.AddComment(Comment ("Ayomikun Temitope", "I have truly obtained mercies."));

            Video03.AddComment(Comment ("Imole Esther", "The lyrics are captivating."));
            Video02.AddComment(Comment ("Tope Deborah", "May you continue to be a vessel in God’ hand"));
            Video01.AddComment(Comment ("Shade Lukmon", "Mercy can truly break protocol"));

            Video03.AddComment(Comment ("Segun Farinto", "I like the lyrics that say he got time and season in His hands."));
            video02.AddComment(Comment ("Seyi Adewale", "The hymns are powerful. More fire on your altar"));
            video01.AddComment(Comment ("Tomiwa Tosin", "The Instrumentation was perfect."));

            var videos = new List<Video> {video03, video02, video01};

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

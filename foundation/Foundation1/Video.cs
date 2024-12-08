    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int DurationInSeconds { get; set; }
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int durationInSeconds)
        {
            Title = title;
            Author = author;
            DurationInSeconds = durationInSeconds;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public List<Comment> GetComments()
        {
            return Comments;
        }
    }

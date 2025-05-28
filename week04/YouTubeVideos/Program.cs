using System;
using System.Collections.Generic;

namespace YouTubeAbstraction
{
    class Comment
    {
        public string AuthorName { get; }
        public string CommentText { get; }

        public Comment(string authorName, string commentText)
        {
            AuthorName = authorName;
            CommentText = commentText;
        }
    }
    class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int LengthInSeconds { get; }
        private List<Comment> comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("Learning C#", "John Smith", 600);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Could you explain delegates next?"));

            Video video2 = new Video("Introduction to Programming", "Mary Johnson", 900);
            video2.AddComment(new Comment("Dave", "Perfect for beginners."));
            video2.AddComment(new Comment("Eve", "Loved the examples."));
            video2.AddComment(new Comment("Frank", "Please make a part 2!"));

            Video video3 = new Video("Study Tips", "Linda Lee", 300);
            video3.AddComment(new Comment("Grace", "I will try these tips."));
            video3.AddComment(new Comment("Henry", "Thanks for sharing."));
            video3.AddComment(new Comment("Ivy", "Can you make a video on time management?"));

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            foreach (Video v in videos)
            {
                Console.WriteLine($"Title: {v.Title}");
                Console.WriteLine($"Author: {v.Author}");
                Console.WriteLine($"Length (seconds): {v.LengthInSeconds}");
                Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
                Console.WriteLine("Comments:");
                foreach (Comment c in v.GetComments())
                {
                    Console.WriteLine($"- {c.AuthorName}: {c.CommentText}");
                }
                Console.WriteLine(); 
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // First video
        Video video1 = new Video("C# Basics", "Innocent Dzowera", 600);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Nice and simple."));
        video1.AddComment(new Comment("Charlie", "Thanks for this."));
        videos.Add(video1);

        // Second video
        Video video2 = new Video("Abstraction in OOP", "George White", 480);
        video2.AddComment(new Comment("Diana", "Great explanation."));
        video2.AddComment(new Comment("Ethan", "I understand now."));
        video2.AddComment(new Comment("Faye", "Keep it up!"));
        videos.Add(video2);

        // Third video
        Video video3 = new Video("OOP Principles", "CS Guide", 720);
        video3.AddComment(new Comment("George", "Clear and useful."));
        video3.AddComment(new Comment("Hannah", "This helped me study."));
        video3.AddComment(new Comment("Ian", "Thanks for the tips."));
        videos.Add(video3);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length (seconds): {video.lengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($"  {comment.commenterName}: {comment.commentText}");
            }
            // empty line for spacing
            Console.WriteLine("");
        }
    }

}
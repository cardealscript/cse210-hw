using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Cook Pasta", "ChefJohn", 320);
        v1.AddComment(new Comment("Alice", "Great recipe!"));
        v1.AddComment(new Comment("Bob", "I tried this and it was amazing."));
        v1.AddComment(new Comment("Carlos", "Simple and delicious."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        v2.AddComment(new Comment("Diana", "Very helpful, thank you!"));
        v2.AddComment(new Comment("Eve", "Best C# tutorial I found."));
        v2.AddComment(new Comment("Frank", "Clear and easy to follow."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Top 10 Travel Destinations", "WanderWorld", 480);
        v3.AddComment(new Comment("Grace", "I want to visit all of these!"));
        v3.AddComment(new Comment("Henry", "Great video quality."));
        v3.AddComment(new Comment("Isla", "Added to my bucket list."));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
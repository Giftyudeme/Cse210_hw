using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a list to hold the video instances
            List<Video> videoList = new List<Video>();

            // 2. Create and populate Video 1
            Video video1 = new Video("C# Basics for Beginners", "Programming Academy", 600);
            video1.Comments.Add(new Comment("Gift Udeme", "This cleared up so many things for me. Thanks!"));
            video1.Comments.Add(new Comment("Nikky udeme", "Great explanation of classes and objects."));
            video1.Comments.Add(new Comment("Esther Brown", "Can you make a tutorial on Inheritance next?"));
            videoList.Add(video1);

            // 3. Create and populate Video 2
            Video video2 = new Video("How to Bake the Perfect Sourdough", "Chef Maria", 1250);
            video2.Comments.Add(new Comment("Susan Udeme", "My crust finally turned out crispy!"));
            video2.Comments.Add(new Comment("Glory Watson", "What brand of flour do you recommend?"));
            video2.Comments.Add(new Comment("Franklin Castle", "Instructions were clear and easy to follow."));
            videoList.Add(video2);

            // 4. Create and populate Video 3
            Video video3 = new Video("SpaceX Rocket Launch Highlights", "Cosmo News", 420);
            video3.Comments.Add(new Comment("Grace kakar", "Engineering at its finest. Absolutely amazing!"));
            video3.Comments.Add(new Comment("Henry Ekpo", "The camera angles on the landing were incredible."));
            video3.Comments.Add(new Comment("Friday Akpan", "Science always finds a way. Great video."));
            videoList.Add(video3);

            // 5. Iterate through the video list and display all properties
            foreach (Video video in videoList)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine($"Title:       {video.Title}");
                Console.WriteLine($"Author:      {video.Author}");
                Console.WriteLine($"Length:      {video.LengthSeconds} seconds");
                Console.WriteLine($"Comments:    {video.GetCommentCount()} total comments");
                Console.WriteLine("--------------------------------------------------");
                
                // Iterate through and display each comment attached to the video
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.CommenterName}: \"{comment.CommentText}\"");
                }
                Console.WriteLine("==================================================\n");
            }
        }
    }
}

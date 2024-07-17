using System;
using System.Collections.Generic;

namespace YouTubeVideoComments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store videos
            List<Video> videos = new List<Video>();

            // Create 3-4 videos with comments
            Video video1 = new Video("The Legend of Zelda: Breath of the Wild", "John Doe", 600);
            video1.AddComment(new Comment("Alice", "Amazing gameplay!"));
            video1.AddComment(new Comment("Bob", "One of the best games ever!"));
            video1.AddComment(new Comment("Charlie", "Can't wait for the sequel!"));

            Video video2 = new Video("Super Mario Odyssey", "Jane Smith", 1200);
            video2.AddComment(new Comment("Dave", "Such a fun game."));
            video2.AddComment(new Comment("Eve", "Mario games never disappoint."));
            video2.AddComment(new Comment("Frank", "Loved every moment!"));

            Video video3 = new Video("Cyberpunk 2077", "Emily Johnson", 900);
            video3.AddComment(new Comment("George", "The graphics are stunning."));
            video3.AddComment(new Comment("Hannah", "Had a few bugs, but still enjoyed it."));
            video3.AddComment(new Comment("Ivy", "Great story and characters."));

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Iterate through the list of videos and display their information
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}

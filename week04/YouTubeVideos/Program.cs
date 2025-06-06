using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Introduction to C#", "John Doe", 600),
            new Video("Object-Oriented Programming", "Jane Smith", 900),
            new Video("Building a Console App", "Mark Johnson", 750)
        };

        // Adding comments to each video
        videos[0].AddComment("Alice", "Great introduction! Very helpful.");
        videos[0].AddComment("Bob", "Thanks for this video, learned a lot!");

        videos[1].AddComment("Charlie", "OOP concepts explained well.");
        videos[1].AddComment("David", "Can you make a follow-up video on interfaces?");

        videos[2].AddComment("Eve", "Loved the breakdown of console apps.");
        videos[2].AddComment("Frank", "Super clear and easy to follow!");

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
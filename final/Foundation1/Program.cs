using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("10 Amazing C# Tips", "CodeMaster", 612);
        video1.Comments.Add(new Comment("Alice", "Great video, learned a lot!"));
        video1.Comments.Add(new Comment("Bob", "The LINQ section was super helpful."));
        video1.Comments.Add(new Comment("Carlos", "Could you do a follow-up on async/await?"));
        videos.Add(video1);

        Video video2 = new Video("Mountain Biking in Moab", "TrailRider", 847);
        video2.Comments.Add(new Comment("Dave", "That drop at 8:30 was insane!"));
        video2.Comments.Add(new Comment("Emma", "What bike setup are you running?"));
        video2.Comments.Add(new Comment("Frank", "Moab is on my bucket list now."));
        video2.Comments.Add(new Comment("Grace", "Beautiful scenery, thanks for sharing!"));
        videos.Add(video2);

        Video video3 = new Video("Easy Homemade Sourdough Bread", "BakingWithLena", 1023);
        video3.Comments.Add(new Comment("Henry", "Mine came out perfect on the first try!"));
        video3.Comments.Add(new Comment("Isabel", "What hydration percentage do you use?"));
        video3.Comments.Add(new Comment("Jack", "Finally a recipe that actually works."));
        videos.Add(video3);

        Video video4 = new Video("Intro to Object-Oriented Programming", "TechTeacher", 490);
        video4.Comments.Add(new Comment("Karen", "This finally clicked for me, thank you!"));
        video4.Comments.Add(new Comment("Leo", "Best OOP explanation on YouTube."));
        video4.Comments.Add(new Comment("Mia", "The encapsulation example was very clear."));
        video4.Comments.Add(new Comment("Noah", "More videos like this please!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("  " + comment.CommenterName + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}

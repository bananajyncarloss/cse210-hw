using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Understanding Classes", "Programming", 600);
        Video video2 = new Video("Mission Life Vlog", "Elder Banaña", 900);
        Video video3 = new Video("BYU–Idaho Campus Tour", "Student Life", 720);

        video1.AddComment(new Comment("Anna", "This was very helpful!"));
        video1.AddComment(new Comment("Mark", "Great explanation."));
        video1.AddComment(new Comment("John", "I finally understand classes."));

        video2.AddComment(new Comment("Sarah", "This reminds me of my mission."));
        video2.AddComment(new Comment("David", "So inspiring!"));
        video2.AddComment(new Comment("Luke", "Thanks for sharing this experience."));

        video3.AddComment(new Comment("Emily", "I want to study here someday."));
        video3.AddComment(new Comment("Chris", "Beautiful campus!"));
        video3.AddComment(new Comment("Noah", "This helped me decide where to apply."));
        video3.AddComment(new Comment("Jane", "Very informative tour."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine();
        Console.WriteLine("YOUTUBE");
        Console.WriteLine("Welcome to YouTube!");
        Console.WriteLine("");

        Video v1 = new Video("The law of Gravity", "Issac Newton", 120);
        v1.AddComment(new Comment("John Doe", "This video is actually really good and makes a lot of sense"));
        v1.AddComment(new Comment("Cap America", "To be honest I really didnt understand the video"));
        v1.AddComment(new Comment("Tony Stark", "I already knew all of this"));
        videos.Add(v1);

        Video v2 = new Video("The Fact of Making Friends", "Jordan Peterson", 150);
        v2.AddComment(new Comment("Jon Smith", "I could really connect with this video!"));
        v2.AddComment(new Comment("Josh Crocker", "I really wish I would have found this video a lot earlier."));
        v2.AddComment(new Comment("Michael Jordan", "To be honest, I saw a lot of videos before this one, I like this way you explain it."));
        videos.Add(v2);

        Video v3 = new Video("DIY: How to make a cake out of dirt", "Mark Zukerberg", 60);
        v3.AddComment(new Comment("Clark Kent", "I was more confused not going to lie."));
        v3.AddComment(new Comment("Bruce Wayne", "JUSTICE."));
        v3.AddComment(new Comment("Steven Universe", "Yo I love you dude, I appreciate everything that you have done, but I think you might have to stick to Facebook! Love you tho. On accident"));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}
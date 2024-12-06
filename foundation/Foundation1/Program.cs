using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the YOUTUBE playlist!");
        Console.WriteLine("--------------------------------------------------");
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Baby Shark Song", "PinkFong", 137);

        Comment v1Comment1 = new Comment("Austin", "This song is catchy!");
        video1.AddComment(v1Comment1);
        Comment v1Comment2 = new Comment("Deya", "I love this song!");
        video1.AddComment(v1Comment2);
        Comment v1Comment3 = new Comment("Sam", "This is so funny!");
        video1.AddComment(v1Comment3);
        Comment v1Comment4 = new Comment("Lauren", "This is my type of jam!");
        video1.AddComment(v1Comment4);
        _videos.Add(video1);

        Video video2 = new Video("Wheels On The Bus", "Cocomelon", 228);

        Comment v2Comment1 = new Comment("Liam", "I learned this song as a kid!");
        video2.AddComment(v2Comment1);
        Comment v2Comment2 = new Comment("Peyton", "Makes me want to sing this on a bus!");
        video2.AddComment(v2Comment2);
        Comment v2Comment3 = new Comment("Aiden", "I've never taken a bus before.");
        video2.AddComment(v2Comment3);
        _videos.Add(video2);

        Video video3 = new Video("The Lazy Song", "Bruno Mars", 299);

        Comment v3Comment1 = new Comment("Benny", "The video is crazy!");
        video3.AddComment(v3Comment1);
        Comment v3Comment2 = new Comment("London", "The monkeys are wild!");
        video3.AddComment(v3Comment2);
        Comment v3Comment3 = new Comment("Spencer", "This is my new favorite song!");
        video3.AddComment(v3Comment3);
        Comment v3Comment4 = new Comment("Abby", "Bruno Mars is so good!");
        video3.AddComment(v3Comment4);
        Comment v3Comment5 = new Comment("Isa", ":)");
        video3.AddComment(v3Comment5);
        _videos.Add(video3);

        foreach(Video video in _videos)
        {
            video.DisplayInfo();
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
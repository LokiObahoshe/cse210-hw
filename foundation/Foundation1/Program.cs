using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Draw My Life", "DenisDaily", 500);
        Video video2 = new Video("How to cook shrimp", "CoolCat", 1020);
        Video video3 = new Video("Explosion Sound affect (5 seconds)", "NoCopyrightSounds", 5);
        Video video4 = new Video("Top 10 Scary Stories", "Shiver_Your_Timbers", 3600);

        video1.AddComment("SirMeowsALot", "This video is great <3");
        video1.AddComment("MrFlimFlam", "Amazing video as always!");
        video2.AddComment("MarioLover101", "YUMMYYYY");
        video2.AddComment("ExplosionGang1247", "Thank you for this great video");
        video3.AddComment("LordHater06", "Lol");
        video3.AddComment("Destroyerman_", "WE LOVE EXPLOSIONS1!!!11");
        video3.AddComment("NirvanaFan", "Best video on youtube");
        video3.AddComment("XxThePresidentxX", "I vote this video 1000/10");
        video3.AddComment("tigerlillywee", "BOOM");
        video4.AddComment("gFwfifiwfiwfwh", "this is to scaryy, Im onley 9");
        video4.AddComment("ParanormalBeliever5000000", "I swear I saw a ghost this mornin");
        video4.AddComment("ILikeSoup", "NEED MORE TOP 10 SCARY VIDEOS, NOW!!!");

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (var video in _videos)
        {
            DisplayInformation(video);
        }
    }

    static void DisplayInformation(Video video)
    {
        Console.WriteLine(video);
    }
}
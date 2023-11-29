using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Sign of the Times", "Harry Styles", 197);
        Comment comment1video1 = new Comment("SottSav", "A BANGER!");
        video1.comments.Add(comment1video1);
        Comment comment2video1 = new Comment("WatermelonMel", "Hey Alexa, play Sign of the Times");
        video1.comments.Add(comment2video1);
        Comment comment3video1 = new Comment("Adoreyouuu", "10/10");
        video1.comments.Add(comment3video1);

        videos.Add(video1);

        Video video2 = new Video("12 Hour Deep Dive into Survivor", "Wendigoon", 43200);
        Comment comment1video2 = new Comment("_itssavy", "Jeff Probst is the man"); 
        video2.comments.Add(comment1video2);
        Comment comment2video2 = new Comment("Brodawg", "Heroes v. Villians is the best season!");
        video2.comments.Add(comment2video2);
        Comment comment3video2 = new Comment("BostonRob4Evr", "Boston Rob is the best player!");
        video2.comments.Add(comment3video2);

        videos.Add(video2);

        Video video3 = new Video("Try Not to Laugh: Karen Edition", "Cody Ko", 1087);
        Comment comment1video3 = new Comment("BugsBunny", "LOLLLLL");
        video3.comments.Add(comment1video3);
        Comment comment2video3 = new Comment("DaffyDuck", "Karens be wildin");
        video3.comments.Add(comment2video3);
        Comment comment3video3 = new Comment("Tazzzz_", "Sheeeeesh");
        video3.comments.Add(comment3video3);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.VideoDetails());
            video.DisplayComments();
        }
    
    }
}
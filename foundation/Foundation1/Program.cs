class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create some videos
        Video video1 = new Video { Title = "Video 1", Author = "Author 1", LengthInSeconds = 300 };
        Video video2 = new Video { Title = "Video 2", Author = "Author 2", LengthInSeconds = 450 };
        Video video3 = new Video { Title = "Video 3", Author = "Author 3", LengthInSeconds = 600 };

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "I learned a lot."));

        video2.AddComment(new Comment("UserA", "Awesome content!"));
        video2.AddComment(new Comment("UserB", "Keep it up!"));
        video2.AddComment(new Comment("UserC", "Thanks for sharing."));

        video3.AddComment(new Comment("ViewerX", "Fantastic explanation."));
        video3.AddComment(new Comment("ViewerY", "Love this channel!"));
        video3.AddComment(new Comment("ViewerZ", "Subscribed!"));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (var video in videos)
        
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments())

            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}

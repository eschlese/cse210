using System;

class Program
{
    static void Main(string[] args)
    {
        Comment commentOne = new Comment("Mike", "This is a fake comment, what a great video.");
        Comment commentTwo = new Comment("Frank", "Another fake comment. Great video.");
        Comment commentThree = new Comment("Ted", "I didn't even watch this video.");
        Comment commentFour = new Comment("Jessica", "10/10 video, would recommend to a friend.");

        List<Comment> commentList = new List<Comment>
        {
            commentOne, commentTwo, commentThree, commentFour
        };

        Video videoOne = new Video("First Video", "John Doe", 80, commentList);
        Video videoTwo = new Video("Second Video", "Ruby", 120, commentList);
        Video videoThree = new Video("Third Video", "Jake Smith", 30, commentList);
        Video videoFour = new Video("Fourth Video", "Anna Lowry", 200, commentList);

        List<Video> videoList = new List<Video>
        {
            videoOne, videoTwo, videoThree, videoFour
        };

        foreach (Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
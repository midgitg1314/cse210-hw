using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video {Title = "How to milk a cow", Author = "Gage Smith", Length = 200};
        video1.AddComment("Jennifer", "Thats cool!");
        video1.AddComment("Alex", "Very Insightful!");
        
        Video video2 = new Video {Title = "How to grow a flower", Author = "Jennifer Victoria", Length = 300};
        video2.AddComment("Bill", "Learned a lot!");
        video2.AddComment("Steve", "So interesting!");
        
        Video video3 = new Video {Title = "How to build a computer", Author = "Alex Cordova", Length = 400};
        video3.AddComment("Juan", "Very complicated");
        video3.AddComment("Fred", "Great Work Friend!");
        
        List<Video> videosList = new List<Video> {video1, video2, video3};
        
        foreach (Video video in videosList)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: "+ video.Author);
            Console.WriteLine("Length: "+ video.Length + " seconds");
            Console.WriteLine("Number of Comments: "+ video.GetNumComments());
            
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
    }
}
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}

// Video Class
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
        }

        Console.WriteLine();
    }
}

// Program Class
class Program
{
    static void Main(string[] args)
    {
        // Create Videos
        Video video1 = new Video("C# Basics Tutorial", "CodeMaster", 600);
        Video video2 = new Video("Learn OOP in C#", "Tech Academy", 850);
        Video video3 = new Video("Top 10 VS Code Extensions", "DevTips", 420);
        Video video4 = new Video("How to Build a Portfolio Website", "Web Genius", 900);

        // Add Comments to Video 1
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Sarah", "Very easy to understand."));
        video1.AddComment(new Comment("Mike", "Thanks for sharing."));

        // Add Comments to Video 2
        video2.AddComment(new Comment("David", "OOP finally makes sense."));
        video2.AddComment(new Comment("Grace", "Excellent explanation."));
        video2.AddComment(new Comment("Emma", "This helped my assignment a lot."));

        // Add Comments to Video 3
        video3.AddComment(new Comment("Chris", "Awesome extensions."));
        video3.AddComment(new Comment("Daniel", "I use most of these already."));
        video3.AddComment(new Comment("Sophia", "Very helpful video."));

        // Add Comments to Video 4
        video4.AddComment(new Comment("James", "Clean design ideas."));
        video4.AddComment(new Comment("Linda", "I built my first portfolio today."));
        video4.AddComment(new Comment("Victor", "Fantastic walkthrough."));

        // Store videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display all videos and comments
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}

using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private float _length;

    private List<Comment> _comments;

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle
    {
        get { return _title; }
        set { _title = value; }
    }

    public string GetAuthor
    {
        get { return _author; }
        set { _author = value; }
    }

    public float GetDuration//Time must be in seconds
    {
        get { return _length; }
        set { _length = value; }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string DisplayCommentsDetail()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\n";
    }
}
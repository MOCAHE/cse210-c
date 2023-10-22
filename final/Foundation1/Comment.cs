using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _commentContent;

    public Comment(string commenterName, string commentContent)
    {
        _commenterName = commenterName;
        _commentContent = commentContent;
    }

    public string GetCommenterName
    {
        get { return _commenterName; }
        set { _commenterName = value; }
    }

    public string GetComment
    {
        get { return _commentContent; }
        set { _commentContent = value; }
    }

    public string DisplayCommentsDetail()
    {
        return $"@{_commenterName}: \n{_commentContent}\n";
    }

}
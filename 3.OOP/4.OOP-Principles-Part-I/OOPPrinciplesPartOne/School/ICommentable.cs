using System.Collections.Generic;

public interface ICommentable
{
    string[] Comments { get; }
    void AddComment(string comment);
}


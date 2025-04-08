using System;

public class Video
    {
        public string title;
        public string author;
        public int lengthInSeconds;
        public List<Comment> comments;

        public Video(string videoTitle, string videoAuthor, int videoLength)
        {
            title = videoTitle;
            author = videoAuthor;
            lengthInSeconds = videoLength;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetAllComments()
        {
            return comments;
        }
    }
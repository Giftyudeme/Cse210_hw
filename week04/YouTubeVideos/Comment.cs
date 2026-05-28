using System;

namespace YouTubeVideos
{
    public class Comment
    {
        // Responsibility: Track the name of the commenter and the text message
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        // Constructor to easily instantiate a comment with data
        public Comment(string name, string text)
        {
            CommenterName = name;
            CommentText = text;
        }
    }
}

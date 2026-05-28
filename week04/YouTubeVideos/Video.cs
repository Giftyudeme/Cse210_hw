using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        // Responsibility: Track video details
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthSeconds { get; set; }
        
        // Responsibility: Store a list of comments
        public List<Comment> Comments { get; set; }

        // Constructor initializing the video details and empty comment list
        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
            Comments = new List<Comment>();
        }

        // Responsibility: Return the total number of comments
        public int GetCommentCount()
        {
            return Comments.Count;
        }
    }
}

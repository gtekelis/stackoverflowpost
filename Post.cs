using System;

namespace stackoverflowpost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        private int Votes { get; set; }

        public static Post CreatePost(string title, string description)
        {
            var post = new Post();
            post.Title = title;
            post.Description = description;
            post.CreationDate = DateTime.Now;

            return post;
        }

        public void Upvote()
        {
            Votes += 1;
            System.Console.WriteLine($"Current number of votes: {Votes}");
        }

        public void DownVote()
        {
            if (Votes > 0)
                Votes -= 1;

            System.Console.WriteLine($"Current number of votes: {Votes}");
        }

    }
}

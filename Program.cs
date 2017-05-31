using System;

namespace stackoverflowpost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Post. Enter 'up' to upvote or 'dn' to downvote. Type 'exit to quit'");

            string inputTitle = null;
            string inputDescription = null;

            while (String.IsNullOrEmpty(inputTitle))
            {
                System.Console.WriteLine("Post title");
                inputTitle = Console.ReadLine().Trim();
            }

            while (String.IsNullOrEmpty(inputDescription))
            {
                System.Console.WriteLine("Post description");
                inputDescription = Console.ReadLine().Trim();
            }

            var post = Post.CreatePost(inputTitle, inputDescription);

            System.Console.WriteLine($"You created a post with title: {post.Title} and description: {post.Description}");
            System.Console.WriteLine($"The post was created on {post.CreationDate.Day}-{post.CreationDate.Month}-{post.CreationDate.Year} {post.CreationDate.TimeOfDay}");
            System.Console.WriteLine("You can now Upvote or Downvote the post");

            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "up":
                        {
                            post.Upvote();
                            break;
                        }
                    case "dn":
                        {
                            post.DownVote();
                            break;
                        }
                    case "exit":
                        {
                            Environment.Exit(0);
                            System.Console.WriteLine("Thank you for using Post");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("not valid input");
                            break;
                        }
                }
            }
        }
    }
}

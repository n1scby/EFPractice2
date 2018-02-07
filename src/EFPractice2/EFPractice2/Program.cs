using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blog myBlog = new Blog
            //{
            //    Url = "ccalearn.tech",
            //    Rating = 4
            //};

            using (var db = new BloggingContext())
            {
                var myBlog = db.Blogs.Include(b => b.Posts).FirstOrDefault(b => b.BlogId == 1);

                for (int i = 0; i < 10; i++)
                {
                    var myPost = new Post
                    {
                        Blog = myBlog,
                        Title = $"Post {i}",
                        BlogId = myBlog.BlogId,
                        Content = $"<h1>The Second Post!</h1><p>This is post {i}</p>"
                    };

                    // db.Blogs.Add(myBlog);
                    db.Posts.Add(myPost);
                }
                db.SaveChanges();
            }

                Console.WriteLine("Hello World!");
        }
    }
}

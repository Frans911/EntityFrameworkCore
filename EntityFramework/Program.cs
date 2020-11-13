using EntityFramework.Data;
using EntityFramework.Data.Entities;
using System;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with Entity Framework");

            using (var database = new BloggingContext())
            {

                //CREATE
                Console.WriteLine("Inserting a new blog");
                database.Add(new Blog { BlogUrl = "http://blogs.msdn.com/adonet" });
                database.SaveChanges();

                //READ
                Console.WriteLine("Querying for a blog");
                var blog = database.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();
                Console.WriteLine(blog);

                //UPDATE
                Console.WriteLine("Updating a blog and adding a post");
                blog.BlogUrl = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(new Post { 
                        Title = "Entity Framework",
                        Content = "Getting started with EF is absolutely thrilling...:)"
                    });

                database.SaveChanges();
                Console.WriteLine(blog);

                //DELETE
                //Console.WriteLine("Delete the blog");
                //database.Remove(blog);
                //database.SaveChanges();

            }

            Console.ReadKey();
        }
    }
}

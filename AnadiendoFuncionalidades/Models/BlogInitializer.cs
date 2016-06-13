using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnadiendoFuncionalidades.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            context.Posts.Add(
               new Post()
               {
                   Author = "José M. Aguilar",
                   Title = "Hello, world!",
                   Code = "hello-world",
                   Date = new DateTime(2005, 8, 12),
                   Text = "Hi, everybody, this is my first blog post!",
                   Comments = new[] {
                     new Comment() { Author = "John Doe", Date = new DateTime(2005, 8,13), Text="Hey, this is great!" },
                     new Comment() { Author = "Peter Petersen", Date = new DateTime(2005, 8,14), Text="Good news! Keep writing, please :)" }
                  }
               }
            );
            context.Posts.Add(new Post()
            {
                Author = "José M. Aguilar",
                Title = "Second post",
                Code = "second-post",
                Date = new DateTime(2005, 8, 22),
                Text = "Well, it's time to start writing... :)"
            });
            context.Posts.Add(new Post()
            {
                Author = "José M. Aguilar",
                Title = "Today is my birthday",
                Code = "today-is-my-birthday",
                Date = new DateTime(2005, 9, 1),
                Text = "Today is my birthday! I accept gifts ;)"
            });

            // Other seed data

            base.Seed(context);
        }
    }
}
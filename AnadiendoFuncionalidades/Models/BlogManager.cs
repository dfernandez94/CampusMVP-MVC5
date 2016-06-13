using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AnadiendoFuncionalidades.Models
{
    public class BlogManager : IDisposable
    {
        BlogContext _data = new BlogContext();

        public IEnumerable<Post> GetLatestPosts(int max)
        {
            var posts = from post in _data.Posts
                        orderby post.Date descending
                        select post;
            return posts.Take(max).ToList();
        }

        public IEnumerable<Post> GetPostsByDate(int year, int month)
        {
            var posts = from post in _data.Posts
                        where post.Date.Month == month && post.Date.Year == year
                        orderby post.Date descending
                        select post;
            return posts.ToList();
        }

        public Post GetPost(string code)
        {
            return _data.Posts.Include(p => p.Comments).FirstOrDefault(post => post.Code == code);
        }

        public void Dispose()
        {
            _data.Dispose();
        }
    }
}
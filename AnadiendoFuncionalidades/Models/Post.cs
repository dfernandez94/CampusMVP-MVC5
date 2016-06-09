using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnadiendoFuncionalidades.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }
}
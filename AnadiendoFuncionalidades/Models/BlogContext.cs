﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnadiendoFuncionalidades.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection") { }
        public DbSet<Post> Posts { get; set; }
    }
}
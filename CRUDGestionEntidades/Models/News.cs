using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDGestionEntidades.Models
{
    public class News
    {
        public int id { set; get; }
        [StringLength(40)]
        public String titulo { set; get;  }
        [Required,StringLength(1200)]
        public String texto { set; get; }
        [Url]
        public String url { set; get; }
        public DateTime fecha { set; get; }
        
    }
}
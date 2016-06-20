using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnadiendoFuncionalidades.Models
{
    public class Address
    {
        [StringLength(50), Required]
        public string Street { get; set; }

        [StringLength(5)]
        public string ZipCode { get; set; }
    }
}
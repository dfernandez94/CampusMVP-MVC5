using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioEdicion.Models
{
    public class UserRepository
    {
        public static bool Exists(string nickName)
        {
            //var invalidNames = new[] { "john", "peter", "mark", "jose" };
            //return invalidNames.Any(n => n == nickName);
            return true;
        }
    }
}
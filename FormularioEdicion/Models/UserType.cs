using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioEdicion.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IEnumerable<UserType> getUserTypes()
        {
            yield return new UserType() { Id = 1, Name = "Standard" };
            yield return new UserType() { Id = 2, Name = "Advanced" };
            yield return new UserType() { Id = 3, Name = "Admin" };
        }
    }
}
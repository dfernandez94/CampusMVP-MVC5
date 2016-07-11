using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioEdicion.Models
{
    public class UserViewModel
    {
        [Display(Name = "Nombre"), StringLength(50), Remote("UsernameAvaiblable","User")]
        public String name { set; get; }

        [Display(Name = "Apellido"), Required,MinLength(3),MaxLength(20)]
        public String nickName { set; get; }

        [Display(Name = "Tipo"), Range(0,3)]
        [UIHint("UserTypeEditor")]
        public int type { set; get; }

        [Display(Name = "Email"), Required, EmailAddress, MaxLength(100)]
        public String email { set; get; }

        [Display(Name = "Contraseña"), Required,MaxLength(20),MinLength(5), DataType(DataType.Password)]
        public String password { set; get; }

        [Display(Name = "Repite contraseña"), System.ComponentModel.DataAnnotations.Compare ("password"), DataType(DataType.Password)]
        public String rePassword { set; get; }

        [Display(Name = "Fecha cumpleaños"), DataType(DataType.DateTime)]
        public DateTime birthdate { set; get; }

        [Display(Name = "Habilitado"), HiddenInput]
        public bool enabled { set; get; }

        public static IEnumerable<UserType> getTipos() {
            return UserType.getUserTypes();
        }       
    }
}
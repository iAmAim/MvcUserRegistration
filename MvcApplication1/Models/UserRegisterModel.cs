using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UserRegistrationApplication.Models
{
    public class UserRegisterModel
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage = "Name can not be blank")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Passoword can not be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email can not be blank")]
        public string Email { get; set; }


    }
}

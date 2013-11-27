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
        public string Password { get; set; }
        public string Email { get; set; }


    }
}

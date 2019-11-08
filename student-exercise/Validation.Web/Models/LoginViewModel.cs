using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please supply an Email")]
        [EmailAddress(ErrorMessage ="Please supply a valid Email. (e.g., johnDoe@aol.com")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please supply a password")]
        public string Password { get; set; }

        public LoginViewModel() { }

        public LoginViewModel(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
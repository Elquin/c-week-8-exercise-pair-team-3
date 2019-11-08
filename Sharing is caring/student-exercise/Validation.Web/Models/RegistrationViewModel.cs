using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Please supply your first name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please supply your last name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please supply your Email")]
        [EmailAddress(ErrorMessage ="Please supply a valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please supply your Email")]
        [EmailAddress(ErrorMessage = "Please supply a valid Email")]
        [Compare(nameof(Email), ErrorMessage = "Emails do not match")]  
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Please supply a password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Please provide a password with a minimum length of 8")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please supply a password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Please provide a password with a minimum length of 8")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]   
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please supply your Birth Date")]
        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please supply a number of tickets")]
        [Range(1, 10)]
        public int NumberOfTickets { get; set; }

        public RegistrationViewModel() { }

        public RegistrationViewModel(string firstName, string lastName, string email, string confirmEmail, string password, string confirmPassword, DateTime birthDate, int numberOfTickets)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ConfirmEmail = confirmEmail;
            Password = password;
            ConfirmPassword = confirmPassword;
            BirthDate = birthDate;
            NumberOfTickets = numberOfTickets;
        }
    }
}
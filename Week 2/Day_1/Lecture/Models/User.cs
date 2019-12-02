using System;
using System.ComponentModel.DataAnnotations;

namespace Lecture.Models
{
    public class User
    {
        [Display(Name="First Name: ")]
        [Required]
        [MinLength(2)]
        public string fName {get;set;}
        [Required]
        [MinLength(2)]
        public string lName {get;set;}
        [Required]
        [EmailAddress]
        public string email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmp {get;set;}
    }
}
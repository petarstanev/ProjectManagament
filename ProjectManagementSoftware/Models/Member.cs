using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementSoftware.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter valid email.")]
        [Display(Name = "Email address:")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password :")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Your password should be of at least 6 characters")]
        public string Password { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
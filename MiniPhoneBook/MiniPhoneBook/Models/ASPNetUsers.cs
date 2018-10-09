using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class ASPNetUsers
    {
        [Key]
        public string UserID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set;}
        [Required(ErrorMessage = "Email is required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "BOB is required")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required(ErrorMessage = "AddedBy is required")]
        public string AddedBy { get; set; }

        [Required(ErrorMessage = "HomeAddress is required")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Name of City is required")]
        public string HomeCity { get; set; }

        public Nullable<System.DateTime> UpdateOn { get; set; }

        public string FaceBookAccount { get; set; }

        public string LinkedIn { get; set; }

        public string TwitterId { get; set; }


        [Required(ErrorMessage = "EmailID is required")]
        public string EmailId { get; set; }
    }
}
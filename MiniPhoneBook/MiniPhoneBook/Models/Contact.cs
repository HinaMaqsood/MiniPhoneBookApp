using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "ContactNumber is required")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Type of Contact Number is required")]
        public string Type { get; set; }
        [Key]
        public int PersonId { get; set; }
    }
}
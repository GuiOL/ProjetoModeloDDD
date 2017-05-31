using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [MaxLength(150, ErrorMessage = "Max {0} characters.")]
        [MinLength(2, ErrorMessage = "Min {0} characters.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(150, ErrorMessage = "Max {0} characters.")]
        [MinLength(2, ErrorMessage = "Min {0} characters.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [MaxLength(150, ErrorMessage = "Max {0} characters.")]
        [MinLength(2, ErrorMessage = "Min {0} characters.")]
        [EmailAddress(ErrorMessage = "E-mail not valid.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Register { get; set; }

        public bool Active { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
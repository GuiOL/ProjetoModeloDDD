using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(150, ErrorMessage = "Max {0} characters.")]
        [MinLength(2, ErrorMessage = "Min {0} characters.")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999")]
        [Required(ErrorMessage = "Price is required.")]
        [DisplayName("Price")]
        public decimal Value { get; set; }

        [DisplayName("Available?")]
        public bool Available { get; set; }

        public int ClientId { get; set; }
        
        public virtual ClientViewModel Client { get; set; }
    }
}
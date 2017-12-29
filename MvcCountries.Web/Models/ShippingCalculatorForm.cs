using System.ComponentModel.DataAnnotations;

namespace MvcCountries.Web.Models
{
    public class ShippingCalculatorForm
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        public string EmailAddress { get; set; }

        [Required]
        public string CountryCode { get; set; }

        [Required]
        [Range(0, 2000)]
        public decimal OrderAmount { get; set; }

        public int ShippingDiscount { get; set; }
    }
}
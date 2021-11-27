using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem.Models
{
    public class InsertCompanyCustomerModel
    {
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters and Space are allowed")]
        [StringLength(250, ErrorMessage = "The Company length should be between 4 and 250.", MinimumLength = 4)]
        [Required(ErrorMessage = "The Company Name field is required.")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters and Space are allowed")]
        [StringLength(250, ErrorMessage = "The Company Address length should be between 4 and 250.", MinimumLength = 4)]
        [Required(ErrorMessage = "The Company Address field is required.")]
        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }
        [RegularExpression(@"^([0-9])+$", ErrorMessage = "Only numbers are allowed")]
        [StringLength(10, ErrorMessage = "Company Phone should be of length {2}.", MinimumLength = 10)]
        [Required(ErrorMessage = "The Company Phone field is required.")]
        [Display(Name = "Company Phone")]
        public string CompanyPhone { get; set; }
        [Required(ErrorMessage = "The Company Fax field is required.")]
        [Display(Name = "Company Fax")]
        [RegularExpression(@"^([0-9])+$", ErrorMessage = "Only numbers are allowed")]
        [StringLength(10, ErrorMessage = "Company Fax should be  be between 5 and 10.", MinimumLength = 5)]
        public string CompanyFax { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters and Space are allowed")]
        [StringLength(250, ErrorMessage = "The Shipping Method length should be between 4 and 250.", MinimumLength = 4)]
        [Required(ErrorMessage = "The Shipping Method field is required.")]
        [Display(Name = "Shipping Method")]
        public string ShippingMethod { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Letters and Space are allowed")]
        [StringLength(250, ErrorMessage = "The Buyer Name length should be between 4 and 250.", MinimumLength = 4)]
        [Display(Name = "Buyer Name")]
        public string BuyerName { get; set; }
        [RegularExpression(@"^([0-9])+$", ErrorMessage = "Only numbers are allowed")]
        [StringLength(10, ErrorMessage = "Buyer Phone should be of length {2}.", MinimumLength = 10)]
        [Display(Name = "Buyer Phone")]
        public string BuyerPhone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Buyer Email")]
        public string BuyerEmail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyEats.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Zip { get; set; }

        [Display(Name = "Name on Card")]
        [Required(ErrorMessage = "This field is required")]
        public string NameonCard { get; set; }

        [Display(Name = "Credit Card Number")]
        [Required(ErrorMessage = "This field is required, input valid 16 digit number")]
        //[RegularExpression(@" ([0 - 9][0 - 9][0 - 9][0 - 9]) ([0 - 9][0 - 9][0 - 9][0 - 9]) ([0 - 9][0 - 9][0 - 9][0 - 9]) ([0 - 9][0 - 9][0 - 9][0 - 9])")]
        public string CreditCardNum { get; set; }

        [Display(Name = "Expiration Date")]
        [Required(ErrorMessage = "This field is required, input valid expiration date: MM/YY")]
       // [RegularExpression(@"([0-9][0-9])\/([0-9][0-9])")]
        public string ExpDate{ get; set; }

        [Display(Name = "CVV")]
      //  [RegularExpression(@"([0-9][0-9][0-9])")]
        [Required(ErrorMessage = "This field is required")]
        public string cvv { get; set; }

        [Display(Name = "Total")]
        public decimal YourTotal { get; set; }
        public int UserLinkID { get; set; }


    }
}

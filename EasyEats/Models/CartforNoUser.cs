using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyEats.Models
{
    public class CartforNoUser
    {
        [Display(Name = "Menu Item")]
        public List<MenuItem> TempCart { get; set; }

        [Display(Name = "Price")]
        public decimal TotalCost { get; set; }
        public CartforNoUser()
        {
            TempCart = new List<MenuItem>();
        }
    }
}

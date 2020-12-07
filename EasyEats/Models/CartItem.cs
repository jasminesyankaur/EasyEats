using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyEats.Models
{
    public class CartItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int MenuItemID { get; set; }

        [Display(Name = "Item Name")]
        public MenuItem Menuitem { get; set; }

        [Display(Name = "Price")]
        public decimal TotalCost { get; set; }
    }
}
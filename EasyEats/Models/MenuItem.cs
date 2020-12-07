using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyEats.Models
{
    public class MenuItem
    {
        public int ID { get; set; }

        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }
        public string ItemImagePath { get; set; }
        public decimal Price { get; set; }
        public int RestaurantID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
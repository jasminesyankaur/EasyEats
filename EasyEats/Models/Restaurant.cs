using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyEats.Models
{
    public class Restaurant
    {
        public int ID { get; set; }

        [Display(Name = "Restaurant Name")]
        public string RestaurantName { get; set; }

        [Display(Name = "Description")]
        public string RestaurantDescription { get; set; }

        [Display(Name = "Address")]
        public string RestAddress { get; set; }

        [Display(Name = "Phone Number")]
        public string RestNum { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
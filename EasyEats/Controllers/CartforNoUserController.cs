using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EasyEats.Data;
using EasyEats.Models;

namespace EasyEats.Controllers
{
    public class CartforNoUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NoUserCart(int id, string name, string description, string imagepath, decimal price, int RID)
        {
            MenuItem tempmenuItem = new MenuItem
            {
                ID = id,
                ItemName = name,
                ItemDescription = description,
                ItemImagePath = imagepath,
                Price = price,
                RestaurantID = RID
            };

            CartforNoUser cartforNoUser = new CartforNoUser();

            cartforNoUser.TempCart.Add(tempmenuItem);


            return View(cartforNoUser);
        }


        //public async Task<IActionResult> NoUserCart(int id, string name, string description, string imagepath, decimal price, int RID)
        //{
        //    MenuItem tempmenuItem = new MenuItem
        //    {
        //        ID = id,
        //        ItemName = name,
        //        ItemDescription = description,
        //        ItemImagePath = imagepath,
        //        Price = price,
        //        RestaurantID = RID
        //    };

        //    CartItem cartItem = new CartItem
        //    {
        //        MenuItemID = id,
        //        Menuitem = tempmenuItem,
        //        TotalCost = price,
        //    };

        //    return RedirectToAction("Create", "CartItems", cartItem);
        //}
    }
}

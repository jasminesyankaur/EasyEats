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
    public class CartItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CartItems
        public async Task<IActionResult> Index()
        {
            var easyEatsContext = _context.CartItems.Include(c => c.Menuitem);

            return View(await easyEatsContext.ToListAsync());
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems
                .Include(c => c.Menuitem)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        [HttpPost, ActionName("PayNow")]
        public async Task<IActionResult> PayNow()
        {
            return RedirectToAction("Create", "Orders");
        }

        public async Task<IActionResult> CreateCartItem(int id, string name, string description, string imagepath, decimal price, int RID)
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

            CartItem cartItem = new CartItem
            {
                MenuItemID = id,
                Menuitem = tempmenuItem,
                TotalCost = price,
            };

            return RedirectToAction("Create", "CartItems", cartItem);
        }

        public async Task<IActionResult> Create([Bind("ID,Quantity,MenuItemID,TotalCost")] CartItem cartItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuItemID"] = new SelectList(_context.MenuItems, "ID", "ID", cartItem.MenuItemID);

            return View(cartItem);
        }

        // GET: CartItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return NotFound();
            }
            ViewData["MenuItemID"] = new SelectList(_context.MenuItems, "ID", "ID", cartItem.MenuItemID);
            return View(cartItem);
        }

        // POST: CartItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Quantity,MenuItemID,TotalCost")] CartItem cartItem)
        {
            if (id != cartItem.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(cartItem.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuItemID"] = new SelectList(_context.MenuItems, "ID", "ID", cartItem.MenuItemID);
            return View(cartItem);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems
                .Include(c => c.Menuitem)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemExists(int id)
        {
            return _context.CartItems.Any(e => e.ID == id);
        }
    }
}
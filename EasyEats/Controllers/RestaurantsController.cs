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
    public class RestaurantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        public async Task<IActionResult> AddItem(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return RedirectToAction("GetItem", "MenuItems", new { id });
        }

        public async Task<IActionResult> NoUserAddItem(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return RedirectToAction("NoUserGetItem", "MenuItems", new { id });
        }

        public async Task<IActionResult> Mcdonalds()
        {
            int id = 1;

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant = await _context.Restaurants
                .Include(s => s.MenuItems)
                .AsNoTracking()
                .FirstOrDefaultAsync(nameof => nameof.ID == id);

            return View(restaurant);
        }

        public async Task<IActionResult> BurgerKing()
        {
            int id = 2;

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant = await _context.Restaurants
                .Include(s => s.MenuItems)
                .AsNoTracking()
                .FirstOrDefaultAsync(nameof => nameof.ID == id);

            return View(restaurant);
        }

        public async Task<IActionResult> Chipotle()
        {
            int id = 3;

            var restaurant = await _context.Restaurants
               .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant = await _context.Restaurants
                .Include(s => s.MenuItems)
                .AsNoTracking()
                .FirstOrDefaultAsync(nameof => nameof.ID == id);

            return View(restaurant);
        }

        public async Task<IActionResult> ChickfilA()
        {
            int id = 4;

            var restaurant = await _context.Restaurants
                 .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant = await _context.Restaurants
                .Include(s => s.MenuItems)
                .AsNoTracking()
                .FirstOrDefaultAsync(nameof => nameof.ID == id);

            return View(restaurant);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RestaurantName,RestaurantDescription")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RestaurantName,RestaurantDescription")] Restaurant restaurant)
        {
            if (id != restaurant.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.ID))
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
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(e => e.ID == id);
        }
    }
}
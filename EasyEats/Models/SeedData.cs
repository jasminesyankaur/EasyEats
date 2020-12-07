using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EasyEats.Data;

namespace EasyEats.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Restaurants.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurants.AddRange(
                    new Restaurant
                    {
                        RestaurantName = "McDonalds",
                        RestaurantDescription = "McDonald's Corporation sells hamburgers, chicken sandwiches, French fries, soft drinks, breakfast items, and desserts.",
                        RestAddress = "5495 White Rock Rd. Fort Worth, TX 76244",
                        RestNum = "(214) 356 - 7924",
                    },

                    new Restaurant
                    {
                        RestaurantName = "Burger King",
                        RestaurantDescription = "Burger King Corporation, restaurant company specializing in flame-broiled fast-food hamburgers.",
                        RestAddress = "3600 Park Vista blvd. Fort Worth, TX 76244",
                        RestNum = "(682) 778 - 9671",
                    },

                    new Restaurant
                    {
                        RestaurantName = "Chipotle",
                        RestaurantDescription = "Chipotle is a fast-casual chain that's known for its build-your-own burritos, rice bowls, and other Mexican dishes.",
                        RestAddress = "2121 Future st. Fort Worth, TX 76244",
                        RestNum = "(214) 311 - 8912",
                    },

                    new Restaurant
                    {
                        RestaurantName = "Chick-fil-A",
                        RestaurantDescription = "Chick-fil-A is one of the largest American fast food restaurant chains and the largest whose specialty is chicken sandwiches.",
                        RestAddress = "4157 Lin Brook st. Fort Worth, TX 76244",
                        RestNum = "(214) 121 - 5547",
                    }
                );
                context.SaveChanges();


                // Look for any movies.
                if (context.MenuItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.MenuItems.AddRange(
                    new MenuItem
                    {
                        ItemName = "McGriddles Breakfast Sandwich",
                        ItemDescription = "Bacon, Egg & Cheese McGriddles.",
                        Price = 2.79m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Double Cheeseburger",
                        ItemDescription = "Features two 100% pure beef burger patties seasoned with just a pinch of salt and pepper. It's topped with tangy pickles, chopped onions, ketchup, mustard and two slices of melty American cheese.",
                        Price = 1.69m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Premium Salad",
                        ItemDescription = "Wholesome, high quality salad.",
                        Price = 5.39m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Chicken Nuggets",
                        ItemDescription = "10 piece Chicken McNuggets.",
                        Price = 4.49m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Egg McMuffin",
                        ItemDescription = "Freshly cracked egg on a toasted English Muffin topped with real butter and add lean Canadian bacon and melty American cheese.",
                        Price = 2.79m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Happy Meal",
                        ItemDescription = "Contains hamburger, a side item french fries, and a coke.",
                        Price = 3.29m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Big Mac",
                        ItemDescription = "100% pure beef patties and Big Mac sauce sandwiched between a sesame seed bun.",
                        Price = 3.99m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "French Fries",
                        ItemDescription = "These epic fries are crispy and golden on the outside and fluffy on the inside.",
                        Price = 1.79m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Apple Pie",
                        ItemDescription = "McDonald's Baked Apple Pie is loaded with 100% American-grown apples, with a lattice crust baked to perfection and topped with sprinkled sugar.",
                        Price = 0.99m,
                        RestaurantID = 1,
                    },

                    new MenuItem
                    {
                        ItemName = "Grilled Chicken Sandwich",
                        ItemDescription = "BK’s Grilled Chicken Sandwich features a potato bun, marinated chicken breast, classic tomatoes, lettuce and mayo garnishing.",
                        Price = 3.99m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Bacon Double XL",
                        ItemDescription = "Double patty, bacon and cheese.",
                        Price = 1.69m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Croissan'Wich",
                        ItemDescription = "Hefty, delicious and not-particularly-healthy breakfast sandwich is served on a buttery croissant with sausage to compliment the fluffy eggs and cheese.",
                        Price = 5.39m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Whopper Jr.",
                        ItemDescription = "A flame broiled beef patty topped with ketchup, mayo, and fresh veggies, stacked in between two sesame seed buns.",
                        Price = 4.49m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Original Chicken Sandwich",
                        ItemDescription = "Lightly breaded breast fillet topped with lettuce and mayo.",
                        Price = 2.79m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Whopper Quarter",
                        ItemDescription = "Pound of flame broiled beef with lettuce, tomato, sliced onions and pickles.",
                        Price = 3.29m,
                        RestaurantID = 2,
                    },

                    new MenuItem
                    {
                        ItemName = "Onion Rings",
                        ItemDescription = "Classic onion rings.",
                        Price = 3.99m,
                        RestaurantID = 2,
                    },

                     new MenuItem
                     {
                         ItemName = "Steak Burrito",
                         ItemDescription = "Rice, steak, salsa, corn, cheese and lettuce.",
                         Price = 7.50m,
                         RestaurantID = 3,
                     },

                    new MenuItem
                    {
                        ItemName = "Chicken Burrito",
                        ItemDescription = "Rice, chicken, salsa, corn, cheese and lettuce.",
                        Price = 6.50m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Carne Asada Burrito",
                        ItemDescription = "Rice, carne asada, salsa, corn, cheese and lettuce.",
                        Price = 6.95m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Veggie Burrito",
                        ItemDescription = "Rice, veggies, salsa, corn, cheese and lettuce.",
                        Price = 6.50m,
                        RestaurantID = 3,
                    },


                    new MenuItem
                    {
                        ItemName = "Steak Bowl",
                        ItemDescription = "Rice, steak, salsa, corn, cheese and lettuce.",
                        Price = 7.50m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Chicken Bowl",
                        ItemDescription = "Rice, chicken, salsa, corn, cheese and lettuce.",
                        Price = 6.50m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Carne Asada Bowl",
                        ItemDescription = "Rice, carne asada, salsa, corn, cheese and lettuce.",
                        Price = 6.95m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Veggie Bowl",
                        ItemDescription = "Rice, veggies, salsa, corn, cheese and lettuce.",
                        Price = 6.50m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Guacamole ",
                        ItemDescription = "Side of guacamole.",
                        Price = 2.99m,
                        RestaurantID = 3,
                    },

                    new MenuItem
                    {
                        ItemName = "Chicken Nuggets",
                        ItemDescription = "Classic crispy chicken nuggets.",
                        Price = 3.05m,
                        RestaurantID = 4,
                    },

                    new MenuItem
                    {
                        ItemName = "Chick-n-Strips",
                        ItemDescription = "Boneless chicken tenders marinated in special seasonings, freshly-breaded and pressure cooked in 100% refined peanut oil.",
                        Price = 4.19m,
                        RestaurantID = 4,
                    },

                    new MenuItem
                    {
                        ItemName = "Chicken Biscuit",
                        ItemDescription = "A breakfast portion of our famous boneless breast of chicken, seasoned to perfection, hand-breaded, pressure cooked in 100% refined peanut oil and served on a buttermilk biscuit.",
                        Price = 2.69m,
                        RestaurantID = 4,
                    },

                    new MenuItem
                    {
                        ItemName = "Chicken Sandwich",
                        ItemDescription = "The classic Chick-fil-A chicken sandwich with pickles.",
                        Price = 3.75m,
                        RestaurantID = 4,
                    },

                    new MenuItem
                    {
                        ItemName = "Waffle Fries",
                        ItemDescription = "Waffle-shaped potatoes with the skin. Cooked in canola oil until crispy outside and tender inside.",
                        Price = 1.95m,
                        RestaurantID = 4,
                    }
                );
                context.SaveChanges();


            }
        }
    }
}
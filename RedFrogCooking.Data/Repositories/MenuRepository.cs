using RedFrogCooking.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public IEnumerable<MenuCategory> GetCategories()
        {
            return categories;
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return items.Where(item => item.Display == true);
        }


        private List<MenuCategory> categories = new List<MenuCategory>()
        {
            new MenuCategory()
            {
                Id = "desery",
                Name = "Desery",
                Icon = "fa fa-coffee fa-2x",
                Description = "Przepyszne"
            }, 
            new MenuCategory()
            {
                Id = "daniaglowne",
                Name = "Dania Glowne",
                Icon = "fa fa-hamburger fa-2x",
                Description = "Najlepsze"
            },
             new MenuCategory()
            {
                 Id = "startery",
                Name = "Startery",
                 Icon = "fa fa-utensils fa-2x",
                Description = "Lekkie"
            }
        };

        List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem
            {
                Id = "id1",
                Name = "Hamburger",
                Description = "",
                Price = 14.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne,startery"

            },
             new MenuItem
            {
                Id = "id2",
                Name = "Lody waniliowe",
                Description = "Najlepsze w miescie",
                Price = 12.5M,
                ImageUrl = "img/menu-2.jpg",
                Display = true,
                Categories = "desery"
            },
             new MenuItem
            {
                Id = "id3",
                Name = "Kurcze pieczone",
                Description = "The best you can find in the city",
                Price = 23.5M,
                ImageUrl = "img/menu-3.jpg",
                Display = true,
                Categories = "daniaglowne"
            },
             new MenuItem
            {
                Id = "id4",
                Name = "Fish and chips",
                Description = "The best you can find in the city",
                Price = 12.5M,
                ImageUrl = "img/menu-4.jpg",
                Display = true,
                Categories = "daniaglowne"
            },
             new MenuItem
            {
                Id = "id5",
                Name = "Pierogi ruskie",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne"
            },
             new MenuItem
            {
                Id = "id6",
                Name = "Fish soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id7",
                Name = "Fish soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id8",
                Name = "Fish soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id9",
                Name = "Fish soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id10",
                Name = "Pea soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id11",
                Name = "Green bean salat",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id12",
                Name = "Salad",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id13",
                Name = "Onion soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id14",
                Name = "Chocolate pancakes",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id15",
                Name = "Chicken soup",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery,daniaglowne"
            },
             new MenuItem
            {
                Id = "id16",
                Name = "Avocado salad",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id17",
                Name = "Tiramisu",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery"
            },
             new MenuItem
            {
                Id = "id18",
                Name = "Big ice creams",
                Description = "",
                Price = 32,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery"
            },
             new MenuItem
            {
                Id = "id19",
                Name = "Melon salad",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery,startery"
            },
             new MenuItem
            {
                Id = "id20",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne"
            },
             new MenuItem
            {
                Id = "id21",
                Name = "Roasted lemon sola",
                Description = "",
                Price = 22.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne"
            }

        };
    }
}

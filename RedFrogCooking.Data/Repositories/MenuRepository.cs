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
                Icon = "",
                Description = "Przepyszne"
            }, 
            new MenuCategory()
            {
                Id = "daniaglowne",
                Name = "Dania Glowne",
                Icon = "",
                Description = "Najlepsze"
            },
             new MenuCategory()
            {
                 Id = "startery",
                Name = "Startery",
                 Icon = "",
                Description = "Lekkie"
            }
        };

        List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem
            {
                Id = "id1",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne"

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
                Price = 12.5M,
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
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id7",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id8",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id9",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id10",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id11",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id12",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id13",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id14",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id15",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id16",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "startery"
            },
             new MenuItem
            {
                Id = "id17",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery"
            },
             new MenuItem
            {
                Id = "id18",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery"
            },
             new MenuItem
            {
                Id = "id19",
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "desery"
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
                Name = "Chicken burger",
                Description = "",
                Price = 12.5M,
                ImageUrl = "img/menu-1.jpg",
                Display = true,
                Categories = "daniaglowne"
            }

        };
    }
}

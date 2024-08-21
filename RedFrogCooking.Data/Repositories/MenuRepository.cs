using Microsoft.EntityFrameworkCore;
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
        private readonly RedFrogCooking.Data.DataContext.DataContext _dbContext;

        public MenuRepository(DataContext.DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<MenuCategory> GetCategories()
        {
            return _dbContext.MenuCategories;
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _dbContext.MenuItems.Where(item => item.Display == true);
        }

    }
}

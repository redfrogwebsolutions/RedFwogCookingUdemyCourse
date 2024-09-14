using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly DataContext.DataContext _context;

        public MenuItemRepository(DataContext.DataContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<MenuItem>> GetMenuItems()
        {
            return await _context.MenuItems.Where(item => item.Display == true).ToListAsync();
        }

        public async Task<IEnumerable<MenuItem>> GetAllMenuItems()
        {
            return await _context.MenuItems.ToListAsync();
        }

        public async Task<MenuItem?> GetMenuItemById(string id)
        {
            return await _context.MenuItems.FirstOrDefaultAsync(item => item.Id == id);
        }

        public async Task Add(MenuItem item)
        {

            _context.MenuItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task Update(MenuItem item)
        {
            _context.Attach(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuItemExists(item.Id))
                {
                    throw new Exception("menu item not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Delete(string id)
        {
            var menuItem = await _context.MenuItems.FindAsync(id);
            if (menuItem != null)
            {
                _context.MenuItems.Remove(menuItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new //new Exception("menu item not found");
            }
        }

        private bool MenuItemExists(string id)
        {
            return _context.MenuItems.Any(e => e.Id == id);
        }
    }
}

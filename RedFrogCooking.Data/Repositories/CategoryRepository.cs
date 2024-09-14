using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext.DataContext _context;

        public CategoryRepository(DataContext.DataContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<MenuCategory>> GetCategories()
        {
            return await _context.MenuCategories.ToListAsync();
        }

        public async Task<MenuCategory?> GetCategoryById(string Id)
        {
            return await _context.MenuCategories.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task Add(MenuCategory category)
        {
            _context.MenuCategories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task Update(MenuCategory category)
        {
            _context.Attach(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuCategoryExists(category.Id))
                {
                    throw new Exception("category not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task Delete(string id)
        {
            var menucategory = await _context.MenuCategories.FindAsync(id);
            if (menucategory != null)
            {
                _context.MenuCategories.Remove(menucategory);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("category not found");
            }
        }

        private bool MenuCategoryExists(string id)
        {
            return _context.MenuCategories.Any(e => e.Id == id);
        }
    }
}

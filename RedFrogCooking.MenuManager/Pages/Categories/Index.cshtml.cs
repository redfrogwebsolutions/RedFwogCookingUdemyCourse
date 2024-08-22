using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.DataContext;
using RedFrogCooking.Data.Model;

namespace RedFrogCooking.MenuManager.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _context;

        public IndexModel(RedFrogCooking.Data.DataContext.DataContext context)
        {
            _context = context;
        }

        public IList<MenuCategory> MenuCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MenuCategory = await _context.MenuCategories.ToListAsync();
        }
    }
}

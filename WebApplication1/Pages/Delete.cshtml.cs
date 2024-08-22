using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.DataContext;
using RedFrogCooking.Data.Model;

namespace WebApplication1.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _context;

        public DeleteModel(RedFrogCooking.Data.DataContext.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MenuCategory MenuCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menucategory = await _context.MenuCategories.FirstOrDefaultAsync(m => m.Id == id);

            if (menucategory == null)
            {
                return NotFound();
            }
            else
            {
                MenuCategory = menucategory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menucategory = await _context.MenuCategories.FindAsync(id);
            if (menucategory != null)
            {
                MenuCategory = menucategory;
                _context.MenuCategories.Remove(MenuCategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

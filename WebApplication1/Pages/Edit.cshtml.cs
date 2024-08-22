using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.DataContext;
using RedFrogCooking.Data.Model;

namespace WebApplication1.Pages
{
    public class EditModel : PageModel
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _context;

        public EditModel(RedFrogCooking.Data.DataContext.DataContext context)
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

            var menucategory =  await _context.MenuCategories.FirstOrDefaultAsync(m => m.Id == id);
            if (menucategory == null)
            {
                return NotFound();
            }
            MenuCategory = menucategory;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MenuCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuCategoryExists(MenuCategory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MenuCategoryExists(string id)
        {
            return _context.MenuCategories.Any(e => e.Id == id);
        }
    }
}

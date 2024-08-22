using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedFrogCooking.Data.DataContext;
using RedFrogCooking.Data.Model;

namespace WebApplication1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _context;

        public CreateModel(RedFrogCooking.Data.DataContext.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MenuCategory MenuCategory { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MenuCategories.Add(MenuCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

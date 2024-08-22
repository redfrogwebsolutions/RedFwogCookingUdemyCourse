﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.DataContext;
using RedFrogCooking.Data.Model;

namespace WebApplication1.Pages.Dania
{
    public class IndexModel : PageModel
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _context;

        public IndexModel(RedFrogCooking.Data.DataContext.DataContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MenuItem = await _context.MenuItems.ToListAsync();
        }
    }
}

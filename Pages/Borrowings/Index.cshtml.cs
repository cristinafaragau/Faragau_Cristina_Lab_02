﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Faragau_Cristina_Lab_02.Data;
using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context _context;

        public IndexModel(Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}

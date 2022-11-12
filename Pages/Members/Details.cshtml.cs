﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Faragau_Cristina_Lab_02.Data;
using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context _context;

        public DetailsModel(Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context context)
        {
            _context = context;
        }

      public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }
            else 
            {
                Member = member;
            }
            return Page();
        }
    }
}

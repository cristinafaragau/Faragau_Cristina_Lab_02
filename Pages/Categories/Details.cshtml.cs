using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Faragau_Cristina_Lab_02.Data;
using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context _context;

        public DetailsModel(Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}

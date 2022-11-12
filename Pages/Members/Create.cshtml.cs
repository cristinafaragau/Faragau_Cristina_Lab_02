using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Faragau_Cristina_Lab_02.Data;
using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context _context;

        public CreateModel(Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Faragau_Cristina_Lab_02.Data;
using Faragau_Cristina_Lab_02.Models;
using Faragau_Cristina_Lab_02.Models.ViewModels;

namespace Faragau_Cristina_Lab_02.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context _context;

        public IndexModel(Faragau_Cristina_Lab_02.Data.Faragau_Cristina_Lab_02Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookCategoryID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID, int? categoryID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
            .Include(i => i.BookCategories)
            .ThenInclude(c => c.Book)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();
            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                .Where(i => i.ID == id.Value).Single();
                //CategoryData.Books = category.BookCategories;
            }
        }
    }
}

using Faragau_Cristina_Lab_02.Models;
namespace Faragau_Cristina_Lab_02.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}

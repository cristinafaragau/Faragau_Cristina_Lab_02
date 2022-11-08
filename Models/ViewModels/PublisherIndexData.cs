using Faragau_Cristina_Lab_02.Models;

namespace Faragau_Cristina_Lab_02.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}

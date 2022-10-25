using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Faragau_Cristina_Lab_02.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}

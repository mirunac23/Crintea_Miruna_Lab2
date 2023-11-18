using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Crintea_Miruna_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
        [NotMapped]
        public string FullName => string.Format("{0} {1}", FirstName, LastName);
    }
}

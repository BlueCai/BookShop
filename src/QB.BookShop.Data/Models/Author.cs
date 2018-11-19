using System.Collections.ObjectModel;

namespace QB.BookShop.Data.Models
{
    public class Author : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Collection<Book> Books { get; set; }
    }
}

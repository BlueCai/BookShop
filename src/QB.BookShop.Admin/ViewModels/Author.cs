using System.Collections.Generic;

namespace QB.BookShop.Admin.ViewModels
{
    public class Author : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}

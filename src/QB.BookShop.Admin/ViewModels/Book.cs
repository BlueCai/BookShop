using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QB.BookShop.Admin.ViewModels
{
    public class Book : BaseModel
    {
        public string Name { get; set; }

        public string SubName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Author Author { get; set; }
    }
}

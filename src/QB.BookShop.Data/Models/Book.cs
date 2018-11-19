namespace QB.BookShop.Data.Models
{
    public class Book : BaseModel
    {
        public string Name { get; set; }

        public string SubName { get; set; }

        public string Description { get; set; }

        public Author Author { get; set; }
    }
}

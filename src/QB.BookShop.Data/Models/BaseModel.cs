using System;

namespace QB.BookShop.Data.Models
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }

        public bool IsRemoved { get; set; }
    }
}

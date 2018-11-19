using Microsoft.EntityFrameworkCore;
using System;

namespace QB.BookShop.Data.Migrations
{
    public class MigrationContext : BookShopDbContext
    {
        public MigrationContext() : base(new DbContextOptions<BookShopDbContext>())
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=QB_BookShop;uid=sa;pwd=cqb20037126;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

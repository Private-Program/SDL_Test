using Microsoft.EntityFrameworkCore;

namespace SDL_Test.DBContext
{
    public class SalesDBContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public SalesDBContext(DbContextOptions options) : base(options)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Inventories> Inventories { get; set; }
        public DbSet<InventoryProducts> InventoryProducts { get; set; }
    }
}

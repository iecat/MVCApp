using eStore.BL.BO;
using System.Data.Entity;

namespace eStore.DBO
{
    public class eStoreDBContext : DbContext
    {

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ProductsAppliedToOrder> ProductsAppliedToOrder { get; set; }



        //protected eStoreDBContext()
        //{
        //    Database.SetInitializer<eStoreDBContext>(new CreateDatabaseIfNotExists<eStoreDBContext>());
        //}
    }
}

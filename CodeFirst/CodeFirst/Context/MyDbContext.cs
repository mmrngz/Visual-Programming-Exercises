using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options):base(options) 
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        override


        /*    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=.;database:BookStore;uid=sa;pwd=123");
                base.OnConfiguring(optionsBuilder);
            }
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Ignore("ID");
            modelBuilder.Entity<OrderDetail>().HasKey("OrderID", "ProductID"); 
        }

       
        public DbSet<AppUser> appUsers { get; set; }    
        public DbSet<AppUserDetail> appUsersDetail { get; set; }    
        public DbSet<Category> categories { get; set; } 
        public DbSet<Order> orders { get; set; }    
        public DbSet<OrderDetail> ordersDetail { get; set; }    
        public DbSet<Product> products { get; set;}
    


    }
}

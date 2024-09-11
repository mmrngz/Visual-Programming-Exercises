using Microsoft.EntityFrameworkCore;
using MvcProject.DAL.Initializer;
using MvcProject.MAP.Configurations;
using MvcProject.MODEL.Models;

namespace MvcProject.DAL.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
            
        }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);
            modelBuilder.ApplyConfiguration(new OperationConfiguration());
            modelBuilder.Entity<Student>().HasOne<StudentDetail>(s => s.StudentDetail).WithOne(sd=>sd.Student).HasForeignKey<StudentDetail>(x => x.StudentID);
            modelBuilder.Entity<Book>().HasOne(b=>b.Author).WithMany(a=>a.Books).HasForeignKey(b => b.AuthorID);
            modelBuilder.Entity<Book>().HasOne(b=>b.BookType).WithMany(bt=>bt.Books).HasForeignKey(b => b.BookTypeID);
        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<BookType> bookTypes { get; set; }
        public DbSet<Operation> operations { get; set; }
        public DbSet<Student> students { get; set; }   
        public DbSet<StudentDetail> studentsDetail { get; set; } 
        public DbSet<AppUser> appUsers { get; set; }    
        
    }


}

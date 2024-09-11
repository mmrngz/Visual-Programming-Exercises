using LastProject.MODEL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.DAL.Context
{
	public class DatabaseContext : DbContext
	{
		IConfiguration configuration;
		public DatabaseContext(IConfiguration config) 
		{
			configuration = config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(configuration.GetSection("ConnectionStrings:Mssql").Value);
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Brand> brands { get; set; }	
		public DbSet<Customer > customers { get; set; }	
		public DbSet<Role> roles { get; set; }
		public DbSet<Sale> sales { get; set; }	
		public DbSet<Service> services { get; set; }	
		public DbSet<User> users { get; set; }
		public DbSet<Vehicle > vehicles { get; set; }		


	
	}
}

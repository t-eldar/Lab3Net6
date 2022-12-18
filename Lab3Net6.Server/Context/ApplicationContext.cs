using Lab3Net6.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace Lab3Net6.Server.Context;

public class ApplicationContext : DbContext
{
	public DbSet<Todo> Todos { get; set; }
	public DbSet<User> Users { get; set; }
	public ApplicationContext() { }
	public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions)
		: base(dbContextOptions) { }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.LogTo(Console.WriteLine);
		optionsBuilder.EnableSensitiveDataLogging();
		optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=todosdb;Trusted_Connection=True;TrustServerCertificate=True");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>()
			.HasKey(u => u.Id);
		modelBuilder.Entity<Todo>()
			.HasKey(t => t.Id);
	}
}

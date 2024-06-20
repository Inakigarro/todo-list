using Microsoft.EntityFrameworkCore;
using ToDoAPI.Domain;

namespace ToDoAPI.Persistence;

public class ToDoDbContext : DbContext
{
    public DbSet<ToDoItem> Items { get; set; }

    public ToDoDbContext()
    {
    }
    public ToDoDbContext(DbContextOptions options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("ToDoItems");
        modelBuilder.ApplyConfiguration(new ToDoItemEntityTypeConfiguration());
    }
}
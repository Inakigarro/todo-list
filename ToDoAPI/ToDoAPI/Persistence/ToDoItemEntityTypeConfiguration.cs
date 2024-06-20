using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoAPI.Domain;

namespace ToDoAPI.Persistence;

public class ToDoItemEntityTypeConfiguration : IEntityTypeConfiguration<ToDoItem>
{
    public void Configure(EntityTypeBuilder<ToDoItem> builder)
    {
        builder.ToTable("ToDoItems");
        builder.HasKey(x => x.Id);
        builder
            .Property(x => x.Title)
            .HasMaxLength(140)
            .IsRequired();
        builder.Property(x => x.Description);
        builder.Property(x => x.IsComplete).IsRequired();
    }
}
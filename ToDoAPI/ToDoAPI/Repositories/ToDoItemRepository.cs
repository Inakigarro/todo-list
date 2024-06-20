using Microsoft.EntityFrameworkCore;
using ToDoAPI.Contracts;
using ToDoAPI.Domain;
using ToDoAPI.Persistence;

namespace ToDoAPI.Repositories;

public class ToDoItemRepository : IToDoItemRepository
{
    private readonly ToDoDbContext context;

    public ToDoItemRepository(ToDoDbContext context)
    {
        this.context = context;
    }
    
    public async Task Add(ToDoItem item)
    {
        this.context.Items.Add(item);
        await this.context.SaveChangesAsync();
    }

    public async Task<ToDoItem?> GetById(Guid id)
    {
        return await this.context.Items.FindAsync(id);
    }

    public async Task<IEnumerable<ToDoItem>> GetAll()
    {
        return await this.context.Items.ToListAsync();
    }

    public Task<ToDoItem> Update(ToDoItem item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
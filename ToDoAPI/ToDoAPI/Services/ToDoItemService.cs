using ToDoAPI.Contracts;
using ToDoAPI.Domain;

namespace ToDoAPI.Services;

public class ToDoItemService : IToDoItemService
{
    private readonly IToDoItemRepository repository;

    public ToDoItemService(IToDoItemRepository repository)
    {
        this.repository = repository;
    }
    
    public async Task Create(CreateOrUpdateToDoItem item)
    {
        var toDoItem = new ToDoItem();
        toDoItem.SetTitle(item.Title);
        toDoItem.SetDescription(item.Description);
        
        await this.repository.Add(toDoItem);
    }

    public async Task<ToDoItem> GetById(Guid id)
    {
        return await this.repository.GetById(id);
    }

    public async Task<IEnumerable<ToDoItem>> GetAll()
    {
        return await this.repository.GetAll();
    }

    public async Task<ToDoItem> Update(CreateOrUpdateToDoItem item)
    {
        var existingItem = await this.repository.GetById(item.Id);
        if (existingItem is null)
        {
            throw new Exception($"There is no item with id {item.Id}");    
        }
        
        existingItem.SetTitle(item.Title);
        existingItem.SetDescription(item.Description);
        if (item.IsComplete)
        {
            existingItem.MarkComplete();
        }
        
        return await this.repository.Update(existingItem);
    }

    public async Task Delete(Guid id)
    {
        await this.repository.Delete(id);
    }
}
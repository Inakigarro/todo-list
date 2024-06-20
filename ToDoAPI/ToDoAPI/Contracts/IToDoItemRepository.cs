using ToDoAPI.Domain;

namespace ToDoAPI.Contracts;

public interface IToDoItemRepository
{
    public Task Add(ToDoItem item);
    public Task<ToDoItem> GetById(Guid id);
    public Task<IEnumerable<ToDoItem>> GetAll();
    public Task<ToDoItem> Update(ToDoItem item);
    public Task Delete(Guid id);
}
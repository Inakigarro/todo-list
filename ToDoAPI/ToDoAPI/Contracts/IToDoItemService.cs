using ToDoAPI.Domain;

namespace ToDoAPI.Contracts;

public interface IToDoItemService
{
    public Task Create(CreateOrUpdateToDoItem item);
    public Task<ToDoItem> GetById(Guid id);
    public Task<IEnumerable<ToDoItem>> GetAll();
    public Task<ToDoItem> Update(CreateOrUpdateToDoItem item);
    public Task Delete(Guid id);
}
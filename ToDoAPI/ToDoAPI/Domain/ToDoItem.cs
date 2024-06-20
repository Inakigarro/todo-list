namespace ToDoAPI.Domain;

public class ToDoItem
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public bool IsComplete { get; private set; } = false;

    public ToDoItem()
    {
        Id = Guid.NewGuid();
    }
    
    public void SetTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentNullException(nameof(title), "Title cannot be null or empty");
        }
        
        Title = title;
    }

    public void SetDescription(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentNullException(nameof(description), "Description cannot be null or empty");
        }
        
        Description = description;
    }
    
    public void MarkComplete()
    {
        IsComplete = true;
    }
}
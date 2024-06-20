namespace ToDoAPI.Contracts;

/// <summary>
/// Contract used to create or update a ToDo item.
/// </summary>
public record CreateOrUpdateToDoItem
{
    /// <summary>
    /// Gets or sets the ToDo item Id.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the ToDo item title.
    /// </summary>
    public string Title { get; set; } = null!;
    
    /// <summary>
    /// Gets or sets the ToDo item description.
    /// </summary>
    public string Description { get; set; } = null!;
    
    /// <summary>
    /// Gets or sets a value that indicates whether the ToDo item is complete.
    /// </summary>
    public bool IsComplete { get; set; }
}
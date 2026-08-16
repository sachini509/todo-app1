using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class TodoItem
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public bool IsComplete { get; set; }

    public TodoPriority Priority { get; set; } = TodoPriority.Medium;

    public DateOnly? DueDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? CompletedAt { get; set; }
}

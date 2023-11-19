namespace ToDoGrpc.Models;

public class TodoItem
{
    public static int Id { get; set; }
    
    public static string? Title { get; set; }
    
    public static string? Description { get; set; }

    public static string ToDoStatus { get; set; } = "NEW";
    

}
namespace TaskLIst;

public class SearchResults
{
    public string? TaskId { get; set; }
    public string TaskTitle { get; set; }
    public bool IsById => !string.IsNullOrEmpty(TaskId);
    public bool IsByTitle => !string.IsNullOrEmpty(TaskTitle);
    public bool ListAllTasks { get; private set; }
    
    private SearchResults() { }

    public static SearchResults ById(string taskId)
    {
        return new SearchResults {TaskId = taskId};
    }

    public static SearchResults ByTitle(string taskTitle)
    {
        return new SearchResults {TaskTitle = taskTitle};
    }

    public static SearchResults ListAll()
    {
        return new SearchResults {ListAllTasks = true}; 
    }
}
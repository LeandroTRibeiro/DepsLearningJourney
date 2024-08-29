namespace TaskLIst;
public class Task
{
    private static int NextId = 0;
    public int Id;
    private string Title;
    private string Description;
    private Status Status;

    public Task(string title, string description, Status status)
    {
        Id = NextId++;
        Title = title;
        Description = description;
        Status = status;
    }

    public void ShowDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Tarefa: {Id}");
        Console.WriteLine($"Titulo: {Title}");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine("------------------------------");
        Console.WriteLine("");
    }
    
    public int GetID()
    {
        return Id;
    }

    public string GetTitle()
    {
        return Title;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetDescription(string description)
    {
        Description = description;
    }

    public void SetStatus(Status newStatus)
    {
        Status = newStatus;
    }
    
}
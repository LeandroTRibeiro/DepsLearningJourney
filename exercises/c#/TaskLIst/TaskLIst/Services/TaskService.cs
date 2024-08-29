namespace TaskLIst;

public class TaskService
{
    private List<Task> _tasks = new List<Task>();

    public void AddTask(Task task)
    {
        _tasks.Add(task);
        Console.WriteLine("Task added");
    }

    public bool ShowTask(int taskId)
    {
        Task task = FoundTaskById(taskId);

        if (task != null)
        {
            task.ShowDetails();
            return true;
        }

        return false;
    }

    public void ShowLIst()
    {
        Console.Clear();
        if (_tasks.Count > 0)
        {
            foreach (Task task in _tasks)
            {
                task.ShowDetails();
            }
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Sem tarefas no momento!");
        }
    }

    public void RemoveTask(int taskId)
    {
        Task task = FoundTaskById(taskId);

        if (task != null)
        {
            _tasks.Remove(task);
            Console.WriteLine("Tarefa removida com sucesso!");
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    public void AttStatusTask(int taskId, Status newStatus)
    {
        Task task = FoundTaskById(taskId);
        
        if (task != null)
        {
            task.SetStatus(newStatus);
            Console.WriteLine($"Task {taskId} atualizado com sucesso!");
        }
    }

    public void EditTask(int taskId, string title, string description, Status newStatus)
    {
        Task task = FoundTaskById(taskId);

        if (task != null)
        {
            if (title != null)
            {
                task.SetTitle(title);
            }

            if (description != null)
            {
                task.SetDescription(description);
            }

            if (newStatus != null)
            {
                task.SetStatus(newStatus);
            }
            
            Console.WriteLine("Task atualizada com sucesso!");
            task.SetStatus(newStatus);
        }
        
        
    }

    public void SearchTasksById(string taskId)
    {
        List<Task> TasksSearch = FoundTasksById(taskId);

        if (TasksSearch.Any())
        {
            foreach (Task task in TasksSearch)
            {
                task.ShowDetails();
            }
        }
        else
        {
            Console.WriteLine($"Tarefa com o id: {taskId}, não encontrada!");
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
    
    public void SearchTasksByTitle(string taskTitle)
    {
        List<Task> TasksSearch = FoundTasksByTitle(taskTitle);

        if (TasksSearch.Any())
        {
            foreach (Task task in TasksSearch)
            {
                task.ShowDetails();
            }
        }
        else
        {
            Console.WriteLine($"Tarefa com o título: {taskTitle}, não encontrada!");
        }
    }

    private Task FoundTaskById(int taskId)
    {
        
        Task task = _tasks.FirstOrDefault(t => t.GetID() == taskId);

        if (task != null)
        {
            return task;
        }
        else
        {
            Console.WriteLine($"Tarefa com o id: {taskId}, não encontrada!");
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
            return null;
        }
    }

    private List<Task> FoundTasksById(string taskId)
    {
        return _tasks.Where(x => x.GetID().ToString().Contains(taskId, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
    private List<Task> FoundTasksByTitle(string taskTitle)
    {
        return _tasks.Where(x => x.GetTitle().Contains(taskTitle, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
}
using TaskLIst.Utils;

namespace TaskLIst
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TaskService taskService = new TaskService();
            int option = 0;

            do
            {
                MenuHelper.ShowMainMenu();

                option = MenuHelper.GetMenuOption();
                
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa!...");
                        break;
                    case 1:
                        MenuHelper.ReadTask(taskService);
                        break;
                    case 2:
                        MenuHelper.FoundTask(taskService);
                        // if (searchResults != null)
                        // {
                        //     if (searchResults.IsById) taskService.SearchTasksById(searchResults.TaskId);
                        //     if (searchResults.IsByTitle) taskService.SearchTasksByTitle(searchResults.TaskTitle);
                        //     if (searchResults.ListAllTasks) taskService.ShowLIst();
                        //
                        //     int taskId;
                        //     
                        //     Console.WriteLine("Digite o id da task que deseja remover: ");
                        //     while (!int.TryParse(Console.ReadLine(), out taskId))
                        //     {
                        //         Console.WriteLine("ID invalido! DIgite novamente: ");
                        //     }
                        //     
                        //     taskService.RemoveTask(taskId);
                        //
                        //     
                        // }
                        break;
                    case 5:
                        taskService.ShowLIst();
                        Console.WriteLine("Precione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        // SearchResults searchResults = MenuHelper.FoundTask();
                        // if (searchResults != null)
                        // {
                        //     if (searchResults.IsById) taskService.SearchTasksById(searchResults.TaskId);
                        //     if (searchResults.IsByTitle) taskService.SearchTasksByTitle(searchResults.TaskTitle);
                        //     if (searchResults.ListAllTasks) taskService.ShowLIst();
                        //
                        //     int taskId;
                        //     
                        //     Console.WriteLine("Digite o id da task que deseja remover: ");
                        //     while (!int.TryParse(Console.ReadLine(), out taskId))
                        //     {
                        //         Console.WriteLine("ID invalido! DIgite novamente: ");
                        //     }
                        //     
                        //     taskService.RemoveTask(taskId);
                        //
                        //     
                        // }
                        break;
                }
                
            } while (option != 0);
            
        }
    }
}
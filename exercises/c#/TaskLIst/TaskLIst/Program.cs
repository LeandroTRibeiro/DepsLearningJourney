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
                        MenuHelper.ReadAndAddTask(taskService);
                        break;
                    case 2:
                        MenuHelper.RemoveTask(taskService);
                        break;
                    case 3:
                        MenuHelper.EditTask(taskService);
                        break;
                    case 4:
                        MenuHelper.ShowAllTasks(taskService);
                        break;
                    case 5:
                        MenuHelper.FoundTask(taskService);
                        break;
                }
                
            } while (option != 0);
            
        }
    }
}
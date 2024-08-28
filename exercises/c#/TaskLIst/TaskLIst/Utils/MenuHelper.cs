namespace TaskLIst.Utils;

public class MenuHelper
{
    public static void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------ LIsta de Tarefas ------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1 --- Adicionar Tarefa");
        Console.WriteLine("2 --- Remover Tarefa");
        Console.WriteLine("3 --- Editar Tarefa");
        Console.WriteLine("5 --- Listar Tarefas");
        Console.WriteLine("6 --- Buscar Tarefas");
        Console.WriteLine("0 --- Encerrar Programa");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
    }

    public static int GetMenuOption()
    {

        int option;

        Console.WriteLine("Digite a opção desejada:");
        while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 6)
        {
            Console.WriteLine("Opção inválida! Por favor, insira um número entre 0 e 6.");
        }
        
        return option;
    }

    public static void ReadTask(TaskService taskService)
    {
        
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("---------- Adicionar Tarefas -----------");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("");
        Console.WriteLine("Digite um titula para a tarefa: ");
        string title = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine("Digite uma descricao para a tarefa: ");
        string descricao = Console.ReadLine();
    
        
        int statusOption = 0;
        Status status = new Status();
            
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha um status para a tarefa: ");
            Console.WriteLine("1 --- Pendente");
            Console.WriteLine("2 --- Em progresso");
            Console.WriteLine("3 --- Concluida");
            
            Console.WriteLine("Digite a opção desejada:");
            if (int.TryParse(Console.ReadLine(), out statusOption) || statusOption < 1 || statusOption > 3)
            {
                Console.WriteLine("Opção invalida! escolha uma opcao entre 1 e 3.");
            }
            
            switch (statusOption)
            {
                case 1: 
                    status = Status.Pendente;
                    break;
                case 2:
                    status = Status.EmProgresso;
                    break;
                case 3:
                    status = Status.Concluida;
                    break;
            }
            
        } while (statusOption < 1 || statusOption > 3);
        
        taskService.AddTask(new Task(title, descricao, status));
    }

    public static void FoundTask(TaskService taskService)
    {
        int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("----------------- Buscar Tarefas ------------------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 --- Buscar Tarefas pelo ID");
            Console.WriteLine("2 --- Buscar Tarefa pelos titulo");
            Console.WriteLine("3 --- Listar todas tarefas");
            Console.WriteLine("0 --- Voltar para o menu principal");
            
            Console.WriteLine("Digite a opção desejada:");
            while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 3)
            {
                Console.WriteLine("Opção inválida! Por favor, insira um número entre 0 e 3.");
            }

            switch (option)
            {
                case 1: 
                    Console.WriteLine("Digite o ID da tarefa:");
                    if (int.TryParse(Console.ReadLine(), out int taskId))
                    {
                        taskService.SearchTasksById(taskId.ToString());
                        Console.WriteLine("Precisone qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("ID inválido. Tente novamente.");
                    } 
                    break;
                case 2:
                    Console.WriteLine("Digite o título da tarefa:");
                    string title = Console.ReadLine();
                    if (!string.IsNullOrEmpty(title))
                    {
                        taskService.SearchTasksByTitle(title);
                        Console.WriteLine("Precisone qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Título inválido. Tente novamente.");
                    }
                    break;
                case 3:
                    taskService.ShowLIst();
                    Console.WriteLine("Precisone qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (option != 0);
    }

    public static void RemoveTask()
    {
        
    }
}

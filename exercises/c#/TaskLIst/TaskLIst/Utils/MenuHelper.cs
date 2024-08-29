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
        Console.WriteLine("4 --- Listar Tarefas");
        Console.WriteLine("5 --- Buscar Tarefas");
        Console.WriteLine("0 --- Encerrar Programa");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
    }

    public static int GetMenuOption()
    {

        int option;

        Console.WriteLine("Digite a opção desejada:");
        while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 5)
        {
            Console.WriteLine("Opção inválida! Por favor, insira um número entre 0 e 6.");
        }
        
        return option;
    }

    public static void ReadAndAddTask(TaskService taskService)
    {
        
        Console.Clear();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("---------- Adicionar Tarefas -----------");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("");
        Console.WriteLine("Digite um titulo para a tarefa: ");
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

    public static void RemoveTask(TaskService taskService)
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("----------- Remover Tarefas --------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 --- Digitar o id da terfa a remover");
            Console.WriteLine("2 --- Buscar Tarefas");
            Console.WriteLine("0 --- Voltar para o menu principal");
            
            Console.WriteLine("Digite a opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 2)
            {
                Console.WriteLine("Opção invalida! Por favor, insira um número entre 0 e 2.");
            }

            switch (option)
            {
                case 0:
                    Console.WriteLine("Voltando para o menu principal...");
                    break;
                case 1:

                    int taskId;
                    
                    Console.Clear();
                    Console.WriteLine("Digite o id da terfa a remover: ");
                    while (!int.TryParse(Console.ReadLine(), out taskId))
                    {
                        Console.WriteLine("Id invalido! Favor digite um id valido de uma tarefa!");
                    }
                    taskService.RemoveTask(taskId);
                    break;
                case 2:
                    FoundTask(taskService);
                    break;
            }
            
        } while(option != 0);
        
    }

    public static void EditTask(TaskService taskService)
    {
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------ Editar Tarefa ---------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 --- Digitar o id da terfa a editar");
            Console.WriteLine("2 --- Buscar Tarefas");
            Console.WriteLine("0 --- Voltar para o menu principal");
            
            Console.WriteLine("Digite a opção desejada: ");
            while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 2)
            {
                Console.WriteLine("Opção invalida! Por favor, insira um número entre 0 e 2.");
            }

            switch (option)
            {
                case 0: 
                    Console.WriteLine("Voltando para o menu principal...");
                    break;
                case 1:
                    int taskId;
                    
                    Console.Clear();
                    Console.WriteLine("Digite o id da terfa a editar: ");
                    while (!int.TryParse(Console.ReadLine(), out taskId))
                    {
                        Console.WriteLine("Id invalido! Favor digite um id valido de uma tarefa!");
                    }
                    
                    bool task = taskService.ShowTask(taskId);

                    if (task)
                    {
                        string editField;
                        string newTitle = null;
                        string newDescription = null;
                        Status status = new Status();
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gostaria de editar o titulo: ( S / N )");
                            editField = Console.ReadLine().Trim().ToUpper();

                            if (editField == "S")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Digite o novo titulo: ");
                                newTitle = Console.ReadLine();
                            }
                            
                        } while (editField != "S" && editField != "N");
                        
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gostaria de editar a descrição: ( S / N )");
                            editField = Console.ReadLine().Trim().ToUpper();

                            if (editField == "S")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Digite a nova descrição: ");
                                newDescription = Console.ReadLine();
                            }
                            
                        } while (editField != "S" && editField != "N");
                        
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gostaria de editar o status: ( S / N )");
                            editField = Console.ReadLine().Trim().ToUpper();

                            if (editField == "S")
                            {
                                
                                int statusOption;
                                
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
                            }
                            
                        } while (editField != "S" && editField != "N");
                        
                        taskService.EditTask(taskId, newTitle, newDescription, status);
                        
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Tarefa editado com sucesso!");
                        taskService.ShowTask(taskId);
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    FoundTask(taskService);
                    break;
            }
        } while(option != 0);
    }

    public static void ShowAllTasks(TaskService taskService)
    {
        taskService.ShowLIst();
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
                case 0: 
                    Console.WriteLine("Voltando para o menu principal...");
                    break;
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
                    break;
            }
        } while (option != 0);
    }
    
}

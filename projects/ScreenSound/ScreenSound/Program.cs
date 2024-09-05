
namespace ScreenSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Album queenAlbum = new Album();
            
            queenAlbum.Name = "A night at the opera";
            Music music1 = new Music();
            music1.Name = "Love of my life";
            Music music2 = new Music();
            music2.Name = "Bohemian Rhapsody";
            
            queenAlbum.AddMusic(music1);
            queenAlbum.AddMusic(music2);
            
            queenAlbum.ShowAlbumMusics();
        }
    }
}



#region OldVersion
// Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
// bands.Add("Linkin Park", new List<int>() { 10, 8, 6 });
// bands.Add("U2", new List<int>() { 1, 3, 9 });
// bands.Add("Metalica", new List<int>());
//
// void ShowWelcomeMsg()
// {
//     string welcomeToAppMsg = "Boas vindos ao ScreenSound!";
//     Console.WriteLine(@"
// ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
// ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
// ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
// ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
// ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
// ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
//     Console.WriteLine(welcomeToAppMsg);
// }
//
// void PauseForUserInput()
// {
//     Console.WriteLine("\nPressione qualquer tecla para continuar...");
//     Console.ReadKey();
// }
//
// void showOptionTitle(string title)
// {
//     Console.Clear();
//     int titleLength = title.Length - 1;
//     string wall = string.Empty.PadLeft(titleLength, '=');
//     Console.WriteLine(wall);
//     Console.WriteLine("Registro de bandas");
//     Console.WriteLine(wall);
// }
//
// void ShowMenu()
// {
//     int option;
//     do
//     {
//         Console.Clear();
//         ShowWelcomeMsg();
//         Console.WriteLine("\n1 --- Registrar banda.");
//         Console.WriteLine("2 --- Mostrar bandas.");
//         Console.WriteLine("3 --- Avaliar banda.");
//         Console.WriteLine("4 --- Exibir media da banda.");
//         Console.WriteLine("0 --- Sair.\n");
//         Console.Write("Digite a opcao escolhida: ");
//
//         option = int.Parse(Console.ReadLine()!);
//
//         switch (option)
//         {
//             case 0:
//                 Console.WriteLine($"Saindo do sistema ...");
//                 break;
//             case 1:
//                 RegisterBands();
//                 break;
//             case 2:
//                 ShowAllBands();
//                 break;
//             case 3:
//                 RatingBand();
//                 break;
//             case 4:
//                 ShowAvarageBand();
//                 break;
//             default:
//                 Console.WriteLine($"Opcao Invalida! \"{option}\"");
//                 PauseForUserInput();
//                 break;
//         }
//
//     } while (option != 0);
//
// }
//
// void RegisterBands()
// {
//     
//     showOptionTitle("Registro de bandas: ");
//     Console.Write("Digite o nome da banda que deseja registrar: ");
//     string bandName = Console.ReadLine()!;
//     
//     bands.Add(bandName, new List<int>());
//     
//     Console.WriteLine($"A banda \"{bandName}\" foi registrada com sucesso!");
//     PauseForUserInput();
// }
//
// void ShowAllBands()
// {
//     showOptionTitle("Listagem de bandas: ");
//
//     foreach (string bandName in bands.Keys)
//     {
//         Console.WriteLine($"\nNome da banda: {bandName}\n");
//     }
//     
//     PauseForUserInput();
// }
//
// void RatingBand()
// {
//     showOptionTitle("Avaliar banda: ");
//     Console.Write("Digite o nome da banda que deseja avaliar: ");
//     string bandName = Console.ReadLine()!;
//
//     if (!bands.ContainsKey(bandName))
//     {
//         Console.WriteLine("Nenhuma banda foi encontrada!");
//         PauseForUserInput();
//     }
//     else
//     {
//         Console.Write($"Digite uma nota para {bandName}: ");
//         int rating = int.Parse(Console.ReadLine()!);
//         bands[bandName].Add(rating);
//         Console.WriteLine("Nota adicionada com sucesso!");
//         PauseForUserInput();
//     }
// }
//
// void ShowAvarageBand()
// {
//     showOptionTitle("Media da banda: ");
//     Console.Write("\nDigite o nome da banda que deseja vizualizar a media: ");
//     string bandName = Console.ReadLine()!;
//     
//     if (!bands.ContainsKey(bandName))
//     {
//         Console.WriteLine("Nenhuma banda foi encontrada!");
//         PauseForUserInput();
//     }
//     else
//     {
//         Console.Write($"\n{bandName} tem a media de: {bands[bandName].Average()}\n");
//         PauseForUserInput();
//     }
//     
// }
//
// ShowMenu();
#endregion


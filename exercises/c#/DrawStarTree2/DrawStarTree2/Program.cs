namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        int treeHeight = 0;
        
        Console.WriteLine("Digite o tamanho da arvore: ");
        treeHeight = int.Parse(Console.ReadLine()!);
        
        PrintTree(treeHeight);
        
    }

    static void PrintTree(int height)
    {

        for (int i = 0; i <= height; i++)
        {
            for (int j =  0; j <= height - i; j++)
            {
                Console.Write(' ');
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write('*');
            }
            
            Console.WriteLine();
        }
        
    }
}
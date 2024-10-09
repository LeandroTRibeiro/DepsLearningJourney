namespace DrawStarTree;

public class Program
{
    static void Main(string[] args)
    {
        int treeHeight;
        
        Console.WriteLine("Qual tamanho da arvore? ");
        treeHeight = int.Parse(Console.ReadLine()!);

        DrawStarTree(treeHeight);
        Console.WriteLine();
        DrawReverseStarTree(treeHeight);
        
    }

    static void DrawStarTree(int height)
    {
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }

    static void DrawReverseStarTree(int height)
    {
        for (int i = height; i >= 0; i--)
        {
            for (int j = 0; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}
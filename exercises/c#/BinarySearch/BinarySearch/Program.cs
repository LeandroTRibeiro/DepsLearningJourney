namespace BinarySearch
{
    
    // Você recebeu um array desordenado de números inteiros e precisa encontrar a posição de um número específico dentro desse array. Para resolver esse problema de maneira eficiente, você utilizará o algoritmo de Busca Binária.
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 45, 23, 89, 67, 12, 78, 56, 101, 34, 99, 82, 16, 73, 58, 109 };
            
            Array.Sort(array);
            Console.WriteLine(BinarySearch(array, 23));

        }

        static string BinarySearch(int[] array, int target)
        {
            int lower = 0;
            int higher = array.Length - 1;
            int counter = 0;

            while (lower <= higher)
            {
                Console.WriteLine($"Numero de operacoes: {counter+1}");
                counter++;
                
                int middle = (lower + higher) / 2;

                if (array[middle] == target)
                {
                    return $"Numero {target} encontrado no indice '{middle}'";
                }

                if (array[middle] < target)
                {
                    lower = middle + 1;                
                }

                if (array[middle] > target)
                {
                    higher = middle - 1;
                }
                
            }
            
            return $"Numero {target} nao encontrado na lista!";
        }
    }
}
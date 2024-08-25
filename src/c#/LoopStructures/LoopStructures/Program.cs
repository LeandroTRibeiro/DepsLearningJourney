namespace LoopStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            #region Laço for

            // Itera sobre o array usando um for loop
            Console.WriteLine("Mostrando todos elementos do array com o laço for: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            #endregion

            #region Laço While
            
            // Itera sobre o array usando um while loop
            int j = 0;
            Console.WriteLine("\nMostrando todos elementos do array com o laço while: ");
            while (j < numbers.Length)
            {
                Console.Write($"{numbers[j]} ");
                j++;
            }
            
            #endregion

            #region Laço do while 
            
            // Itera sobre o array usando um do while loop
            int k = 0;
            Console.WriteLine("\nMostrando todos elementos do array com o laço do while: ");

            do
            {
                Console.Write($"{numbers[k]} ");
                k++;
            } while (k < numbers.Length);
            
            #endregion

            #region Laço foreach

            // Itera sobre o array usando um foreach loop
            Console.WriteLine("\nMostrando todos elementos do array com o laço foreach: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            
            #endregion
            
            #region Saindo de Laços com Break
            
            // Itera sobre o array usando um foreach loop e interrompe a iteracao dependendo da condicao
            Console.WriteLine("\nMostrando todos elementos do array menores que 5 com o laço foreach: ");

            foreach (int number in numbers)
            {
                if (number >= 5)
                {
                    break;
                }
                
                Console.Write($"{number} ");
            }
            
            #endregion
        }
    }
}
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays unidimensionais
            // Declaração de um array de inteiros com 10 elementos
            int[] numbers = new int[10];
            
            // Acesso dos elementos do array atribuindo e modificando
            numbers[0] = 1;
            numbers[1] = 2;
            Console.WriteLine(numbers[0]); // Exibe 1
            Console.WriteLine(numbers[1]); // Exibe 2
            
            numbers[0] = 3; // Modifica o primeiro elemento do array
            Console.WriteLine(numbers[0]); // Exibe 3
            
            // Declara e inicializa um array com 5 elementos
            string[] cars = {"Audi", "BMW", "Ford", "Toyota", "Nissan"};
            Console.WriteLine($"{cars[0]}, {cars[1]}"); // Exibe "Audi, BMW"
            #endregion
            
            #region Arrays multidimensionais
            // Declaração de um array multidimensional (2x3)
            int[,] arrayBidimensional = new int[2, 3];
            
            // Acesso dos elementos do array atribuindo e modificando
            arrayBidimensional[0, 0] = 1; // Linha 0, Coluna 0
            arrayBidimensional[1, 2] = 5; // Linha 1, Coluna 2
            
            // Exibindo os elementos do array multidimensional
            Console.WriteLine($"Elemento [0,0]: {arrayBidimensional[0, 0]}"); // Exibe 1
            Console.WriteLine($"Elemento [1,2]: {arrayBidimensional[1, 2]}"); // Exibe 5

            // Declarando e inicializando um array multidimensional diretamente
            int[,] predefinedArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"Elemento [0,1]: {predefinedArray[0, 1]}"); // Exibe 2
            
            // Declaração de mais dimencoes
            int[,,] tridimensional = 
            {
                {
                    { 1, 2, 3 }, { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 }, { 10, 11, 12 }
                }
            };            
            
            // Acessando e exibindo os elementos do array tridimensional
            Console.WriteLine($"Elemento [0,0,0]: {tridimensional[0, 0, 0]}"); // Exibe 1
            Console.WriteLine($"Elemento [0,1,0]: {tridimensional[0, 1, 0]}"); // Exibe 4
            Console.WriteLine($"Elemento [1,0,0]: {tridimensional[1, 0, 0]}"); // Exibe 7
            Console.WriteLine($"Elemento [1,1,0]: {tridimensional[1, 1, 0]}"); // Exibe 10

            #endregion

            #region Métodos Instância 

            // Declaração e inicialização de um array unidimensional
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            
            // Length: Obtém o número de elementos no array
            Console.WriteLine($"Comprimento do array: {numbers2.Length}"); // Exibe 5

            // Rank: Obtém o número de dimensões do array
            Console.WriteLine($"Dimensões do array: {numbers2.Rank}"); // Exibe 1 (unidimensional)

            // GetLength(dimension): Obtém o tamanho de uma dimensão específica (aqui, a única dimensão 0)
            Console.WriteLine($"Tamanho da dimensão 0: {numbers2.GetLength(0)}"); // Exibe 5
            
            // GetValue(index): Obtém o valor de um elemento no array 
            Console.WriteLine($"Valor no índice [1]: {numbers2.GetValue(1)}"); // Exibe 2
                                                                               
            // SetValue(value, index): Define o valor para o índice
            numbers2.SetValue(50, 0);
            Console.WriteLine($"Valor no índice [0]: {numbers2.GetValue(0)}"); // Exibe 50

            // Declaração e inicialização de um array bidimensional
            int[,] bidimensional = 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };

            // Length em um array multidimensional: Obtém o número total de elementos
            Console.WriteLine($"Comprimento total do array bidimensional: {bidimensional.Length}"); // Exibe 6

            // Rank em um array multidimensional: Obtém o número de dimensões
            Console.WriteLine($"Dimensões do array bidimensional: {bidimensional.Rank}"); // Exibe 2

            // GetLength em um array multidimensional: Obtém o tamanho de uma dimensão específica
            Console.WriteLine($"Número de linhas: {bidimensional.GetLength(0)}"); // Exibe 2 (linhas)
            Console.WriteLine($"Número de colunas: {bidimensional.GetLength(1)}"); // Exibe 3 (colunas)

            // GetUpperBound(dimension): Obtém o índice do último elemento em uma dimensão específica
            Console.WriteLine($"Último índice da dimensão 0 (linhas): {bidimensional.GetUpperBound(0)}"); // Exibe 1
            Console.WriteLine($"Último índice da dimensão 1 (colunas): {bidimensional.GetUpperBound(1)}"); // Exibe 2

            // GetLowerBound(dimension): Obtém o índice do primeiro elemento em uma dimensão específica
            Console.WriteLine($"Primeiro índice da dimensão 0 (linhas): {bidimensional.GetLowerBound(0)}"); // Exibe 0
            Console.WriteLine($"Primeiro índice da dimensão 1 (colunas): {bidimensional.GetLowerBound(1)}"); // Exibe 0

            #endregion
            
            #region Métodos Estáticos

            // Declaração e inicialização de um array unidimensional
            int[] numbers3 = { 5, 3, 8, 1, 2 };

            // Array.Sort(array): Ordena os elementos do array em ordem crescente
            Array.Sort(numbers3);
            Console.WriteLine("Array ordenado: " + string.Join(", ", numbers3)); // Exibe "1, 2, 3, 5, 8"

            // Array.Reverse(array): Inverte a ordem dos elementos no array
            Array.Reverse(numbers3);
            Console.WriteLine("Array invertido: " + string.Join(", ", numbers3)); // Exibe "8, 5, 3, 2, 1"

            // Array.IndexOf(array, value): Retorna o índice do primeiro elemento igual ao valor especificado
            int index = Array.IndexOf(numbers3, 5);
            Console.WriteLine($"Índice do valor 5: {index}"); // Exibe 1

            // Array.LastIndexOf(array, value): Retorna o índice do último elemento igual ao valor especificado
            int lastIndex = Array.LastIndexOf(numbers3, 2);
            Console.WriteLine($"Último índice do valor 2: {lastIndex}"); // Exibe 3

            // Array.Clear(array, startIndex, length): Define elementos do array para seus valores padrão
            Array.Clear(numbers3, 1, 2); // Zera os elementos nas posições 1 e 2
            Console.WriteLine("Array após Clear: " + string.Join(", ", numbers3)); // Exibe "8, 0, 0, 2, 1"

            // Array.Copy(sourceArray, targetArray, length): Copia elementos de um array para outro
            int[] copiedArray = new int[5];
            Array.Copy(numbers3, copiedArray, 5);
            Console.WriteLine("Array copiado: " + string.Join(", ", copiedArray)); // Exibe "8, 0, 0, 2, 1"

            #endregion
            
        }
    }
}
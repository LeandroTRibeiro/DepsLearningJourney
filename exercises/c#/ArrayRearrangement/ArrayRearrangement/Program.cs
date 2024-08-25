namespace ArrayRearrangement
{
    
    // Você recebeu um array de inteiros contendo tanto números positivos quanto negativos. Sua tarefa é manipular o array para que todos os números negativos sejam movidos para o início do array, seguidos pelos números positivos. Além disso, os números no array devem ser ordenados em ordem crescente, enquanto a ordem dos números negativos deve ser decrescente.
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, -2, -5, 4, 8, -1, 7};
            
            Console.WriteLine(string.Join(",", ArrayRearrangement(array)));
        }

        static int[] ArrayRearrangement(int[] array)
        {
            int[] positive = Array.FindAll(array, x => x > 0);
            int[] negative = Array.FindAll(array, x => x < 0);
            
            Array.Sort(positive);
            Array.Sort(negative);
            Array.Reverse(negative);
            
            int[] concatArray = new int[array.Length];
            
            Array.Copy(negative, 0,concatArray, 0,negative.Length);
            Array.Copy(positive, 0,concatArray, negative.Length, positive.Length);

            return concatArray;
        }
    }
}


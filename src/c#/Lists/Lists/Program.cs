namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaração e Inicialização de Listas

            // Declaração de uma lista de inteiros
            List<int> numbers = new List<int>();
            
            // Adicionando elementos à lista
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            
            Console.WriteLine($"Lista de numeros: {string.Join(", ", numbers)}");
            
            // Inicializando uma lista com elementos
            List<string> cars = new List<string>() { "Ford", "Toyota", "Nissan", "Fiat", "Audi" };   

            Console.WriteLine($"Lista de carros: {string.Join(", ", cars)}");
            
            #endregion
            
            #region Métodos de Instância
            
            // Adicionando um elemento ao final da lista
            numbers.Add(5);
            Console.WriteLine($"Após Add: {string.Join(", ", numbers)}");

            // Adicionando uma coleção de elementos ao final da lista
            numbers.AddRange(new int[] { 6, 7, 8, 9 });
            Console.WriteLine($"Após AddRange: {string.Join(", ", numbers)}");

            // Inserindo um elemento em uma posição específica
            numbers.Insert(0, 0); // Insere 0 na primeira posição
            Console.WriteLine($"Após Insert: {string.Join(", ", numbers)}");

            // Inserindo uma coleção de elementos em uma posição específica
            numbers.InsertRange(2, new int[] { 10, 11 });
            Console.WriteLine($"Após InsertRange: {string.Join(", ", numbers)}");

            // Removendo um elemento específico
            numbers.Remove(5);
            Console.WriteLine($"Após Remove (remover 5): {string.Join(", ", numbers)}");

            // Removendo todos os elementos que atendem a uma condição
            numbers.RemoveAll(x => x > 8);
            Console.WriteLine($"Após RemoveAll (remover > 8): {string.Join(", ", numbers)}");

            // Removendo um elemento em uma posição específica
            numbers.RemoveAt(0); // Remove o primeiro elemento
            Console.WriteLine($"Após RemoveAt: {string.Join(", ", numbers)}");

            // Removendo uma faixa de elementos
            numbers.RemoveRange(2, 2); // Remove dois elementos a partir da posição 2
            Console.WriteLine($"Após RemoveRange: {string.Join(", ", numbers)}");

            // Ordenando a lista
            numbers.Sort();
            Console.WriteLine($"Após Sort: {string.Join(", ", numbers)}");

            // Revertendo a lista
            numbers.Reverse();
            Console.WriteLine($"Após Reverse: {string.Join(", ", numbers)}");

            // Encontrando o primeiro elemento que atende a uma condição
            int firstEven = numbers.Find(x => x % 2 == 0);
            Console.WriteLine($"Primeiro número par encontrado com Find: {firstEven}");

            // Encontrando todos os elementos que atendem a uma condição
            List<int> evens = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine($"Números pares encontrados com FindAll: {string.Join(", ", evens)}");

            // Verificando se a lista contém um elemento específico
            bool containsFour = numbers.Contains(4);
            Console.WriteLine($"Contém 4? {containsFour}");

            // Encontrando o índice do primeiro elemento que atende a uma condição
            int index = numbers.FindIndex(x => x == 4);
            Console.WriteLine($"Índice do primeiro 4: {index}");

            // Encontrando o índice do último elemento que atende a uma condição
            int lastIndex = numbers.FindLastIndex(x => x % 2 == 0);
            Console.WriteLine($"Índice do último número par: {lastIndex}");

            // Convertendo a lista em um array
            int[] array = numbers.ToArray();
            Console.WriteLine($"Convertido para array: {string.Join(", ", array)}");

            // Limpando todos os elementos da lista
            numbers.Clear();
            Console.WriteLine($"Após Clear: {string.Join(", ", numbers)}");

            #endregion
        }
    }
}


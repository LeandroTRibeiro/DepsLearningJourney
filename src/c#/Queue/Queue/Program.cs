namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando e inicializando uma Fila ja com uma coleção de array
            string[] cars = {"Toyota", "Fiat", "Iveco", "Hyundai", "Mazda"}; 
            Queue<string> myQueue1 = new Queue<string>(cars);
            
            // Declarando uma Fila vazia  
            Queue<string> myQueue2 = new Queue<string>();
            
            // Adicionando itens na lista
            myQueue2.Enqueue("Hyundai");
            myQueue2.Enqueue("Fiat");
            myQueue2.Enqueue("Iveco");
            
            // Verificando tamanho das Filas
            Console.WriteLine($"Tamanho Queue1: {myQueue1.Count()}");
            Console.WriteLine($"Tamanho Queue2: {myQueue2.Count()}");
            
            // Verificando se tem um item na Fila
            Console.WriteLine($"Contem \"Mazda\": {myQueue1.Contains("Mazda")}");
            Console.WriteLine($"Contem \"Mazda\": {myQueue2.Contains("Mazda")}");

            // Retirando o primeiro item da Fila com Dequeue
            Console.WriteLine($"Retirando o primeiro item do Queue1 com Dequeue: {myQueue1.Dequeue()}");
            Console.WriteLine($"Retirando o primeiro item do Queue2 com Dequeue: {myQueue2.Dequeue()}");
            
            // Retornando o primeiro elemento de uma Fila usando TryPeek
            if (myQueue1.TryPeek(out string peekedItem))
            {
                Console.WriteLine($"Retornando primeiro elemento Queue1 com TryPeek: {peekedItem}");
            }
            else
            {
                Console.WriteLine("Queue1 está vazia!");
            }
            
            // Removendo o primeiro item da Fila usando TryDequeue
            if (myQueue1.TryDequeue(out string dequeuedItem1))
            {
                Console.WriteLine($"Retirando o primeiro item do Queue1 com TryDequeue: {dequeuedItem1}");
            }
            else
            {
                Console.WriteLine("Queue1 está vazia!");
            }

            if (myQueue2.TryDequeue(out string dequeuedItem2))
            {
                Console.WriteLine($"Retirando o primeiro item do Queue2 com TryDequeue: {dequeuedItem2}");
            }
            else
            {
                Console.WriteLine("Queue2 está vazia!");
            }
            
            // Limpando uma Fila
            myQueue2.Clear();
            Console.WriteLine($"Tamanho Queue2 após Clear: {myQueue2.Count()}");
            
            // Retorna o primeiro elemento de uma Fila
            Console.WriteLine($"Primeiro elemento Queue1: {myQueue1.Peek()}");

            // Lendo a Fila
            foreach (string car in myQueue1)
            {
                Console.WriteLine($"myQueue1 : {car}");
            }
            
        }
    }
}
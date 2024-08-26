# Manipulação de Filas em C# 🚶‍♂️🚶‍♀️

[Código 💻](Queue/Program.cs)

Este projeto demonstra como manipular filas (`Queue`) em C#, utilizando métodos para adicionar, remover, inspecionar e iterar sobre os elementos em uma fila.

## O que é uma Fila?

Uma fila é uma estrutura de dados que segue o princípio **FIFO** (First In, First Out), onde o primeiro elemento adicionado é o primeiro a ser removido. Isso é similar a uma fila de pessoas esperando por atendimento: a primeira pessoa a entrar na fila é a primeira a ser atendida. As filas são úteis em situações onde a ordem de processamento precisa ser preservada.

## Funcionalidades do Código

### 1. Inicialização de Filas

- **Criação de uma fila com elementos predefinidos**:
    ```csharp
    string[] cars = {"Toyota", "Fiat", "Iveco", "Hyundai", "Mazda"}; 
    Queue<string> myQueue1 = new Queue<string>(cars);
    ```

- **Criação de uma fila vazia e adição de elementos**:
    ```csharp
    Queue<string> myQueue2 = new Queue<string>();
    myQueue2.Enqueue("Hyundai");
    myQueue2.Enqueue("Fiat");
    myQueue2.Enqueue("Iveco");
    ```

### 2. Verificação de Conteúdo

- **Verificar o tamanho da fila**:
    ```csharp
    Console.WriteLine($"Tamanho Queue1: {myQueue1.Count()}");
    ```

- **Verificar se um item específico está na fila**:
    ```csharp
    Console.WriteLine($"Contem \"Mazda\": {myQueue1.Contains("Mazda")}");
    ```

### 3. Remoção de Itens

- **Remover o primeiro item da fila**:
    ```csharp
    Console.WriteLine($"Retirando o primeiro item do Queue1 com Dequeue: {myQueue1.Dequeue()}");
    ```

- **Remover o primeiro item da fila com segurança usando `TryDequeue`**:
    ```csharp
    if (myQueue1.TryDequeue(out string dequeuedItem))
    {
        Console.WriteLine($"Retirando o primeiro item do Queue1 com TryDequeue: {dequeuedItem}");
    }
    else
    {
        Console.WriteLine("Queue1 está vazia!");
    }
    ```

### 4. Leitura de Itens

- **Obter o primeiro item da fila sem removê-lo usando `Peek`**:
    ```csharp
    Console.WriteLine($"Primeiro elemento Queue1: {myQueue1.Peek()}");
    ```

- **Obter o primeiro item da fila com segurança usando `TryPeek`**:
    ```csharp
    if (myQueue1.TryPeek(out string peekedItem))
    {
        Console.WriteLine($"Retornando primeiro elemento Queue1 com TryPeek: {peekedItem}");
    }
    else
    {
        Console.WriteLine("Queue1 está vazia!");
    }
    ```

### 5. Limpeza de Fila

- **Remover todos os itens da fila**:
    ```csharp
    myQueue2.Clear();
    Console.WriteLine($"Tamanho Queue2 após Clear: {myQueue2.Count()}");
    ```

### 6. Iteração Sobre a Fila

- **Iterar sobre todos os elementos restantes na fila**:
    ```csharp
    foreach (string car in myQueue1)
    {
        Console.WriteLine($"myQueue1 : {car}");
    }
    ```

## Documentação Oficial 📚

Para mais detalhes sobre o uso de filas (`Queue`) em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/api/system.collections.generic.queue-1).
# Listas em C# 📋

Este projeto demonstra o uso da classe `List<T>` em C#, abordando desde a declaração e inicialização de listas até a manipulação de elementos usando os métodos de instância mais comuns. O código foi criado para ilustrar como trabalhar com listas de forma eficiente e prática dentro de uma aplicação C#.

## O que é uma Lista?

Em C#, `List<T>` é uma coleção genérica que permite armazenar elementos do mesmo tipo. Ao contrário de arrays, que têm um tamanho fixo, uma `List<T>` pode crescer e encolher dinamicamente conforme elementos são adicionados ou removidos. As listas são amplamente usadas por sua flexibilidade e por fornecerem métodos convenientes para manipulação de dados.

## Exemplos Incluídos

### 1. Declaração e Inicialização de Listas

```csharp
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
```

### 2. Métodos de Instância

#### Adição de Elementos

- **`Add(T item)`**: Adiciona um único elemento ao final da lista.
- **`AddRange(IEnumerable<T> collection)`**: Adiciona uma coleção de elementos ao final da lista.

```csharp
numbers.Add(5);
numbers.AddRange(new int[] { 6, 7, 8, 9 });
```

#### Inserção de Elementos

- **`Insert(int index, T item)`**: Insere um elemento em uma posição específica.
- **`InsertRange(int index, IEnumerable<T> collection)`**: Insere uma coleção de elementos em uma posição específica.

```csharp
numbers.Insert(0, 0);
numbers.InsertRange(2, new int[] { 10, 11 });
```

#### Remoção de Elementos

- **`Remove(T item)`**: Remove a primeira ocorrência de um elemento específico.
- **`RemoveAll(Predicate<T> match)`**: Remove todos os elementos que atendem a uma condição.
- **`RemoveAt(int index)`**: Remove o elemento na posição especificada.
- **`RemoveRange(int index, int count)`**: Remove uma faixa de elementos começando na posição especificada.

```csharp
numbers.Remove(5);
numbers.RemoveAll(x => x > 8);
numbers.RemoveAt(0);
numbers.RemoveRange(2, 2);
```

#### Ordenação e Reversão

- **`Sort()`**: Ordena os elementos da lista em ordem crescente.
- **`Reverse()`**: Inverte a ordem dos elementos na lista.

```csharp
numbers.Sort();
numbers.Reverse();
```

#### Busca de Elementos

- **`Find(Predicate<T> match)`**: Retorna o primeiro elemento que atende a uma condição.
- **`FindAll(Predicate<T> match)`**: Retorna todos os elementos que atendem a uma condição como uma nova lista.
- **`FindIndex(Predicate<T> match)`**: Retorna o índice do primeiro elemento que atende a uma condição.
- **`FindLastIndex(Predicate<T> match)`**: Retorna o índice do último elemento que atende a uma condição.
- **`Contains(T item)`**: Verifica se a lista contém um elemento específico.

```csharp
int firstEven = numbers.Find(x => x % 2 == 0);
List<int> evens = numbers.FindAll(x => x % 2 == 0);
int index = numbers.FindIndex(x => x == 4);
int lastIndex = numbers.FindLastIndex(x => x % 2 == 0);
bool containsFour = numbers.Contains(4);
```

#### Conversão e Limpeza

- **`ToArray()`**: Converte a lista em um array.
- **`Clear()`**: Remove todos os elementos da lista.

```csharp
int[] array = numbers.ToArray();
numbers.Clear();
```

## Documentação Oficial 📚

Para mais detalhes sobre `List<T>` em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1).
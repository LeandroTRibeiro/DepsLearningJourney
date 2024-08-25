# Arrays 📊

[Código 💻](Arrays/Program.cs) Acesse o código aqui!.

Este projeto demonstra o uso de arrays em C#, cobrindo desde arrays unidimensionais e multidimensionais até métodos de instância e métodos estáticos da classe `Array`.

## O que é um Array?
Um array é uma estrutura de dados que armazena uma coleção de elementos do mesmo tipo, organizados em uma sequência de índices. Em C#, arrays são alocados em um bloco contínuo de memória, onde cada elemento pode ser acessado diretamente através de seu índice. Arrays são úteis para armazenar múltiplos valores de forma ordenada e eficiente, mas têm tamanho fixo, o que significa que não podem ser redimensionados após a criação.

## 1. Arrays Unidimensionais

Arrays unidimensionais são a forma mais simples de arrays, onde os elementos são organizados linearmente.

### Exemplo de Uso:

- Declaração de um array de inteiros com 10 elementos.
- Atribuição e modificação de valores dentro do array.

```csharp
int[] numbers = new int[10];
numbers[0] = 1;
numbers[1] = 2;
Console.WriteLine(numbers[0]); // Exibe 1
Console.WriteLine(numbers[1]); // Exibe 2

numbers[0] = 3;
Console.WriteLine(numbers[0]); // Exibe 3
```

- Declaração e inicialização de um array de strings:

```csharp
string[] cars = { "Audi", "BMW", "Ford", "Toyota", "Nissan" };
Console.WriteLine($"{cars[0]}, {cars[1]}"); // Exibe "Audi, BMW"
```

## 2. Arrays Multidimensionais

Arrays multidimensionais são arrays com mais de uma dimensão, como matrizes bidimensionais (2D) ou tridimensionais (3D).

### Exemplo de Uso:

- Declaração de um array bidimensional (2x3) e manipulação de seus elementos.

```csharp
int[,] arrayBidimensional = new int[2, 3];
arrayBidimensional[0, 0] = 1;
arrayBidimensional[1, 2] = 5;

Console.WriteLine($"Elemento [0,0]: {arrayBidimensional[0, 0]}"); // Exibe 1
Console.WriteLine($"Elemento [1,2]: {arrayBidimensional[1, 2]}"); // Exibe 5
```

- Declaração de um array tridimensional e acesso a seus elementos.

```csharp
int[,,] tridimensional = 
{
    {
        { 1, 2, 3 }, { 4, 5, 6 }
    },
    {
        { 7, 8, 9 }, { 10, 11, 12 }
    }
};

Console.WriteLine($"Elemento [0,0,0]: {tridimensional[0, 0, 0]}"); // Exibe 1
Console.WriteLine($"Elemento [1,1,0]: {tridimensional[1, 1, 0]}"); // Exibe 10
```

## 3. Métodos de Instância

Métodos de instância operam diretamente em uma instância de array. Eles fornecem informações e manipulação básica dos arrays.

### Exemplo de Uso:

- Obtendo o comprimento de um array:

```csharp
int[] numbers2 = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Comprimento do array: {numbers2.Length}"); // Exibe 5
```

- Usando `GetValue` e `SetValue` para acessar e modificar valores:

```csharp
Console.WriteLine($"Valor no índice [1]: {numbers2.GetValue(1)}"); // Exibe 2
numbers2.SetValue(50, 0);
Console.WriteLine($"Valor no índice [0]: {numbers2.GetValue(0)}"); // Exibe 50
```

- Manipulando arrays bidimensionais:

```csharp
int[,] bidimensional = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine($"Dimensões do array bidimensional: {bidimensional.Rank}"); // Exibe 2
```

## 4. Métodos Estáticos

Os métodos estáticos da classe `Array` fornecem funcionalidades avançadas para manipulação de arrays, como ordenação, inversão, e cópia de elementos.

### Exemplo de Uso:

- Ordenação e inversão de um array:

```csharp
int[] numbers3 = { 5, 3, 8, 1, 2 };
Array.Sort(numbers3);
Console.WriteLine("Array ordenado: " + string.Join(", ", numbers3)); // Exibe "1, 2, 3, 5, 8"

Array.Reverse(numbers3);
Console.WriteLine("Array invertido: " + string.Join(", ", numbers3)); // Exibe "8, 5, 3, 2, 1"
```

- Uso de `Array.IndexOf` e `Array.LastIndexOf`:

```csharp
int index = Array.IndexOf(numbers3, 5);
Console.WriteLine($"Índice do valor 5: {index}"); // Exibe 1

int lastIndex = Array.LastIndexOf(numbers3, 2);
Console.WriteLine($"Último índice do valor 2: {lastIndex}"); // Exibe 3
```

- Cópia de elementos de um array para outro:

```csharp
int[] copiedArray = new int[5];
Array.Copy(numbers3, copiedArray, 5);
Console.WriteLine("Array copiado: " + string.Join(", ", copiedArray)); // Exibe "8, 0, 0, 2, 1"
```

## 5. Documentação Oficial 📚

Para mais detalhes sobre o uso de arrays em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/).
# Métodos de Manipulação de Strings 📝

[Código 💻](StringMethods/Program.cs) Acesse o código aqui!

Este projeto demonstra o uso de vários métodos de manipulação de strings em C#. Ele cobre uma variedade de operações comuns, como substituição de texto, extração de substrings, remoção de espaços em branco, divisão e junção de strings, alteração de maiúsculas e minúsculas, e muito mais.

## O que são Métodos de Manipulação de Strings?

Em C#, strings são objetos imutáveis, o que significa que uma vez criadas, não podem ser alteradas. No entanto, existem muitos métodos disponíveis que permitem criar novas strings baseadas em operações realizadas em strings existentes. Esses métodos são essenciais para manipular e processar texto em aplicações de software.

## Principais Métodos

### 1. `Replace`
Substitui todas as ocorrências de uma substring dentro de uma string por outra substring.

```csharp
string str = "Hello World!";
Console.WriteLine(str.Replace("World", "C#")); // Resultado: Hello C#!
```

### 2. `Substring`
Extrai uma parte da string, começando em um índice específico e tendo um comprimento definido.

```csharp
Console.WriteLine(str.Substring(6, 6)); // Resultado: "World!"
```

### 3. `Trim`, `TrimStart`, `TrimEnd`
Remove espaços em branco do início, do final ou de ambos os lados da string.

```csharp
str = "    Hello World!    ";
Console.WriteLine(str.TrimStart()); // Resultado: "Hello World!    "
Console.WriteLine(str.TrimEnd());   // Resultado: "    Hello World!"
Console.WriteLine(str.Trim());      // Resultado: "Hello World!"
```

### 4. `Split`
Divide a string em um array de strings, usando um delimitador específico.

```csharp
string[] cars = str.Split(", ");
Console.WriteLine($"[\"{string.Join("\", \"", cars)}\"]"); 
// Resultado: ["Toyota", "Fiat", "Iveco", "Audi", "Renault", "Hyundai"]
```

### 5. `Join`
Concatena os elementos de um array de strings em uma única string, separando-os por um delimitador.

```csharp
Console.WriteLine(string.Join(", ", cars)); 
// Resultado: "Toyota, Fiat, Iveco, Audi, Renault, Hyundai"
```

### 6. `ToUpper`, `ToLower`
Converte toda a string para maiúsculas ou minúsculas.

```csharp
str = "Hello World!";
Console.WriteLine(str.ToUpper()); // Resultado: "HELLO WORLD!"
Console.WriteLine(str.ToLower()); // Resultado: "hello world!"
```

### 7. `Contains`
Verifica se uma string contém uma substring específica.

```csharp
Console.WriteLine(str.Contains("Hello")); // Resultado: True
```

### 8. `IndexOf`
Retorna o índice da primeira ocorrência de uma substring.

```csharp
Console.WriteLine(str.IndexOf("World!")); // Resultado: 6
```

### 9. `Remove`
Remove uma parte da string, a partir de um índice específico e com um comprimento definido.

```csharp
Console.WriteLine(str.Remove(6, 6)); // Resultado: "Hello "
```

### 10. `Insert`
Insere uma substring em uma string, em uma posição específica.

```csharp
Console.WriteLine(str.Insert(5, ", C#")); // Resultado: "Hello, C# World!"
```

## Documentação Oficial 📚

Para mais detalhes sobre métodos de manipulação de strings em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/strings/).

# Tipos de Dados 📊

Este projeto apresenta exemplos de diversos tipos de dados em C#, incluindo tipos primitivos e não primitivos. Cada exemplo inclui uma breve explicação sobre o tipo de dado e sua utilização.

## O que são Tipos de Dados?
Em C#, tipos de dados definem o tipo de informações que uma variável pode armazenar e as operações que podem ser realizadas sobre ela. Existem dois principais grupos de tipos de dados:

### Tipos Primitivos
Os tipos primitivos são tipos de dados básicos incorporados na linguagem C#. Eles incluem:

- Tipos Numéricos Inteiros: int, long, short, byte, etc.

- Tipos Numéricos de Ponto Flutuante: float, double, decimal.

- Tipo de Caractere: char.

- Tipo Booleano: bool, que pode conter apenas true ou false.

### Tipos Não Primitivos
Os tipos não primitivos, também conhecidos como tipos de referência, são mais complexos e incluem:

- Strings: Representam uma sequência de caracteres (string).

- Arrays: Coleções de elementos do mesmo tipo.

- Classes e Objetos: Definidos pelo usuário para modelar objetos no mundo real.

- Enums e Structs: Usados para definir conjuntos de constantes e tipos de valor personalizados.

## Tipos Primitivos 

- `char`  Representa um único caractere Unicode.
```csharp
char letter = 'L';                 
Console.WriteLine($"char: {letter} - Representa um único caractere Unicode.");
```

- `int` Representa um número inteiro de 32 bits.
```csharp
int age = 33;                      
Console.WriteLine($"int: {age} - Representa um número inteiro.");
```

- `double` Representa um número de ponto flutuante de 64 bits.
```csharp
double height = 1.78;              
Console.WriteLine($"double: {height} - Representa um número de ponto flutuante.");
```

- `bool` Representa um valor booleano (true ou false).
```csharp
bool internship = true;            
Console.WriteLine($"bool: {internship} - Representa um valor booleano (verdadeiro ou falso).");
```

- `float` Representa um número de ponto flutuante de 32 bits.
```csharp
float temperature = 36.6f;         
Console.WriteLine($"float: {temperature} - Representa um número de ponto flutuante menor.");
```

- `decimal` Representa um número decimal de 128 bits, usado principalmente em cálculos financeiros.
```csharp
decimal salary = 50000.75m;        
Console.WriteLine($"decimal: {salary} - Representa um número decimal, usado para cálculos financeiros.");
```

- `long` Representa um número inteiro de 64 bits.
```csharp
long population = 7800000000L;     
Console.WriteLine($"long: {population} - Representa um número inteiro longo.");
```

- `byte` Representa um número inteiro de 8 bits (de 0 a 255).
```csharp
byte ageInYears = 33;              
Console.WriteLine($"byte: {ageInYears} - Representa um número inteiro até 255.");
```

## Tipos adicionais

- `string` Representa uma sequência de caracteres.
```csharp
string name = "Leandro";           
Console.WriteLine($"string: {name} - Representa uma sequência de caracteres.");
```

- `DateTime` Representa a data e hora atuais.
```csharp
DateTime currentDate = DateTime.Now; 
Console.WriteLine($"DateTime: {currentDate} - Representa a data e hora atuais.");
```

- `Guid` Representa um identificador global único (GUID).
```csharp
Guid userId = Guid.NewGuid();      
Console.WriteLine($"Guid: {userId} - Representa um identificador global único.");
```

## Documentação Oficial 📚

Para mais detalhes sobre os tipos de dados em C#, incluindo outros conceitos interessantes como `enum`, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/).



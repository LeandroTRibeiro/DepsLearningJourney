# Hello World 🌏

Este projeto apresenta um exemplo básico em C#, que é o clássico "Hello, World!" uma introdução à sintaxe básica da linguagem. Abaixo, explicamos brevemente os principais elementos do código:

## Explicação do Código 📝

Este projeto apresenta um exemplo básico em C#, que é o clássico "Hello, World!". Abaixo, explicamos brevemente os principais elementos do código:

### namespace

```csharp
namespace HelloWorld
```

O `namespace` agrupa classes e outros tipos de código, ajudando a organizar o projeto e a evitar conflitos de nomes. No exemplo, HelloWorld é o namespace que contém a classe Program.

### class Program

```csharp
class Program
```

A classe `Program` é a unidade básica de código no C#. Ela contém métodos e atributos. Neste caso, `Program` é a classe principal do nosso projeto.

### Método static void Main(string[] args)

```csharp
static void Main(string[] args)
```

- `static`: Indica que o método `Main` pertence à `classe Program` e pode ser chamado sem criar uma instância dessa classe.
- `void`: Significa que o método `Main` não retorna nenhum valor.
- `Main`: O ponto de entrada do programa, onde a execução começa.
- `string[] args`: Um array de strings que pode receber argumentos da linha de comando quando o programa é executado.

### Funcionamento do Código

Dentro do método Main, temos o seguinte comando:

```csharp
Console.WriteLine("Hello, World!");
```

Nesse exemplo, `WriteLine` é o método que pertence à classe Console, e ele imprime o texto "Hello, World!" no console, seguido de uma nova linha.

## Documentação Oficial 📚

A classe `Console` possui vários outros métodos que podem ser encontrados na [documentação oficial](https://learn.microsoft.com/pt-br/dotnet/api/system.console?view=net-8.0).

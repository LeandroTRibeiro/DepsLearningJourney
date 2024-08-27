# Herança em C# 🧬

[Código 💻](Inheritance/Program.cs) Acesse o código aqui!.

Este projeto demonstra o conceito de herança em C# através da implementação de uma hierarquia de classes que modela diferentes tipos de animais. A herança é um dos pilares fundamentais da Programação Orientada a Objetos (POO) e permite que uma classe herde membros (propriedades, métodos) de outra, promovendo a reutilização de código e a criação de hierarquias lógicas entre as classes.

## O que é Herança?

Herança é o mecanismo da POO que permite criar uma nova classe baseada em uma classe existente. A nova classe, chamada de classe derivada, herda atributos e comportamentos (métodos) da classe base. A herança facilita a reutilização de código e a construção de uma estrutura lógica que reflete relações do mundo real.

## Implementação

Neste exemplo, a classe `Animal` é a classe base, enquanto `Mamifero` e `Ave` são classes derivadas que herdam de `Animal`. Classes específicas como `Galinha` e `Canguru` herdam de `Ave` e `Mamifero`, respectivamente. Abaixo, detalhamos a implementação e o relacionamento entre as classes:

### Classe `Animal`

```csharp
public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }

    public Animal() { }

    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
    }
    
    public void MakeNoise()
    {
        Console.WriteLine($"Animal {Name} está fazendo barulho!");
    }
}
```

- **Descrição**: A classe `Animal` é a classe base que define as propriedades comuns a todos os animais, como `Name` e `Color`. Ela também possui um método `MakeNoise`, que pode ser usado por qualquer classe que herde de `Animal`.

### Classe `Mamifero`

```csharp
public class Mamifero : Animal
{
    public int NumberOfLegs { get; set; }

    public Mamifero() { }
    
    public Mamifero(string name, string color, int numberOfLegs) : base(name, color)
    {
        NumberOfLegs = numberOfLegs;
    }
    
    public void FeedYoung()
    {
        Console.WriteLine($"Mamifero {Name} está amamentando seus filhotes.");
    }
}
```

- **Descrição**: A classe `Mamifero` herda de `Animal` e adiciona a propriedade `NumberOfLegs`, que representa o número de pernas de um mamífero. Também introduz o método `FeedYoung`, que simula o ato de amamentar, uma característica exclusiva dos mamíferos.

### Classe `Ave`

```csharp
public class Ave : Animal
{
    public bool CanFly { get; set; }
    
    public Ave() { }

    public Ave(string name, string color, bool canFly) : base(name, color)
    {
        CanFly = canFly;
    }
    
    public void Fly()
    {
        Console.WriteLine($"Ave {Name} está voando...");
    }
}
```

- **Descrição**: A classe `Ave` herda de `Animal` e adiciona a propriedade `CanFly`, que indica se a ave pode voar. Também introduz o método `Fly`, que simula o ato de voar.

### Classe `Galinha`

```csharp
public class Galinha : Ave
{
    public Galinha() { }

    public Galinha(string name, string color, bool canFly) : base(name, color, canFly) { }
    
    public void Scratch()
    {
        Console.WriteLine($"Galinha {Name} está siscando...");
    }
}
```

- **Descrição**: A classe `Galinha` herda de `Ave` e reutiliza o método `Fly` para simular o ato de voar (ou não, dependendo de `CanFly`). Ela também introduz o método `Scratch`, que simula o ato de ciscar, típico das galinhas.

### Classe `Canguru`

```csharp
public class Canguru : Mamifero
{
    public Canguru() { }
    
    public Canguru(string name, string color, int numberOfLegs) : base(name, color, numberOfLegs) { }

    public void Jump()
    {
        Console.WriteLine($"Canguru {Name} está pulando ... ");
    }
}
```

- **Descrição**: A classe `Canguru` herda de `Mamifero` e reutiliza o método `FeedYoung` para simular o ato de amamentar. Ela também introduz o método `Jump`, que simula o ato de pular, uma característica típica dos cangurus.

### Uso das Classes

```csharp
using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de Galinha e define suas propriedades
            Galinha chicken = new Galinha();
            chicken.Name = "Valentina";
            chicken.Color = "branca";
            chicken.CanFly = false;
            
            // Executa métodos da Galinha
            chicken.MakeNoise();
            chicken.Fly();
            chicken.Scratch();
            
            // Cria uma instância de Canguru e define suas propriedades
            Canguru kangaroo  = new Canguru("Jack", "Marrom", 2);
            
            // Executa métodos do Canguru
            kangaroo.MakeNoise();
            kangaroo.FeedYoung();
            kangaroo.Jump();
        }
    }
}
```

## Vantagens da Herança

- **Reutilização de Código**: A herança permite que você reutilize código de classes base, reduzindo a duplicação de código.


- **Hierarquia Lógica**: Ajuda a organizar o código em uma estrutura que reflete as relações do mundo real, facilitando o entendimento e a manutenção.


- **Modularidade**: Cada classe pode ter seu próprio comportamento, mas ainda pode compartilhar funcionalidades comuns da classe base.

## Documentação Oficial 📚

Para mais detalhes sobre herança e outros conceitos de POO em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/inheritance).
# Classes Abstratas em C# 🧩

[Código 💻](Abstraction/Program.cs) Acesse o código aqui!.

Este projeto demonstra o conceito de classes abstratas em C# através de uma hierarquia de classes que modela diferentes tipos de animais. Uma classe abstrata define um contrato para as classes que herdam dela, garantindo que certas funcionalidades sejam implementadas, mas sem fornecer a implementação completa. As classes derivadas são obrigadas a implementar os métodos abstratos definidos na classe base.

## O que é uma Classe Abstrata?

Uma classe abstrata em C# é uma classe que não pode ser instanciada diretamente. Ela pode conter métodos abstratos, que são métodos sem implementação, e métodos concretos, que têm uma implementação padrão. As classes que herdam de uma classe abstrata devem implementar todos os métodos abstratos, ou elas próprias devem ser marcadas como abstratas.

## Implementação

Neste exemplo, a classe `Animal` é uma classe abstrata que define dois métodos abstratos: `MakeSound` e `Move`. As classes derivadas `Dog` e `Cat` implementam esses métodos, fornecendo comportamentos específicos para cada tipo de animal.

### Classe `Animal`

```csharp
namespace Abstraction;

public abstract class Animal
{
    // Propriedade que armazena o nome do animal
    public string Name { get; set; }

    // Método abstrato que deve ser implementado nas classes derivadas para definir o som do animal
    public abstract void MakeSound();

    // Método abstrato que deve ser implementado nas classes derivadas para definir o movimento do animal
    public abstract void Move();
}
```

- **Descrição**: A classe `Animal` serve como uma base para outros tipos de animais. Ela define dois métodos abstratos (`MakeSound` e `Move`), que devem ser implementados pelas classes derivadas.

### Classe `Dog`

```csharp
namespace Abstraction;
// Classe derivada Dog que herda de Animal
public class Dog : Animal
{
    // Implementação do método abstrato MakeSound específico para Dog
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof Woof!");
    }
    
    // Implementação do método abstrato Move específico para Dog
    public override void Move()
    {
        Console.WriteLine("Move to right!");
    }
}
```

- **Descrição**: A classe `Dog` herda de `Animal` e implementa os métodos abstratos `MakeSound` e `Move`, fornecendo uma implementação específica para cães.

### Classe `Cat`

```csharp
namespace Abstraction;
// Classe derivada Cat que herda de Animal
public class Cat : Animal
{
    // Implementação do método abstrato MakeSound específico para Cat
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow Meow!");
    }

    // Implementação do método abstrato Move específico para Cat
    public override void Move()
    {
        Console.WriteLine("Move to left!");
    }
}
```

- **Descrição**: A classe `Cat` herda de `Animal` e implementa os métodos abstratos `MakeSound` e `Move`, fornecendo uma implementação específica para gatos.

### Uso das Classes

```csharp
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe Cat e executa os métodos
            Cat cat = new Cat();
            cat.MakeSound();
            cat.Move();
            
            // Cria uma instância da classe Dog e executa os métodos
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Move();
        }
    }
}
```

- **Descrição**: O programa principal (`Main`) cria instâncias das classes `Cat` e `Dog`, e chama os métodos `MakeSound` e `Move` para cada um. Isso demonstra como as classes derivadas implementam os métodos definidos pela classe abstrata `Animal`.

## Vantagens das Classes Abstratas

- **Consistência**: Garante que todas as classes derivadas implementem os métodos necessários, mantendo uma interface consistente.


- **Reutilização de Código**: Permite que métodos e propriedades comuns sejam definidos na classe base e reutilizados pelas classes derivadas.


- **Flexibilidade**: Classes derivadas podem fornecer suas próprias implementações para métodos abstratos, permitindo comportamentos específicos para diferentes tipos de objetos.

## Documentação Oficial 📚

Para mais detalhes sobre classes abstratas e outros conceitos de Programação Orientada a Objetos (POO) em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-members).

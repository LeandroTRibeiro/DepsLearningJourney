# Polimorfismo em C# 🎭

[Código 💻](Polymorphism/Program.cs) Acesse o código aqui!

Este projeto demonstra o conceito de polimorfismo em C# através da implementação de uma hierarquia de classes que modela diferentes tipos de animais. O polimorfismo é um dos pilares fundamentais da Programação Orientada a Objetos (POO), permitindo que classes derivadas sobrescrevam métodos de uma classe base para modificar ou estender seu comportamento.

## O que é Polimorfismo?

Polimorfismo é a capacidade que objetos de diferentes classes têm de serem tratados como objetos de uma classe base comum, mas ainda exibindo comportamentos específicos de sua classe derivada. Isso é alcançado em C# usando métodos virtuais (`virtual`) e sobrescritos (`override`), onde a classe derivada pode fornecer sua própria implementação de um método herdado da classe base.

## Implementação

Neste exemplo, a classe `Animal` é a classe base, enquanto `Mamifero` e `Ave` são classes derivadas que herdam de `Animal`. Classes específicas como `Galinha` e `Canguru` sobrescrevem métodos das suas classes base para demonstrar o polimorfismo.

### Classe `Animal`

```csharp
public class Animal
{
    // Propriedades básicas comuns a todos os animais
    public string Name { get; set; }
    public string Color { get; set; }

    // Construtor padrão
    public Animal() { }

    // Construtor que inicializa as propriedades comuns
    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
    }
    
    // Método virtual que pode ser usado pela própria classe e por outras classes derivadas
    public virtual void MakeNoise()
    {
        Console.WriteLine($"Animal {Name} esta fazendo barulho!");
    }
}
```

- **Descrição**: A classe `Animal` é a classe base que define propriedades comuns a todos os animais, como `Name` e `Color`. Ela também possui um método `MakeNoise`, que é virtual (`virtual`), permitindo que classes derivadas sobrescrevam este método para fornecer comportamentos específicos.

### Classe `Mamifero`

```csharp
public class Mamifero : Animal
{
    // Propriedade específica para mamíferos
    public int NumberOfLegs { get; set; }

    // Construtor padrão
    public Mamifero() { }
    
    // Construtor que inicializa propriedades de Mamífero e do Animal base
    public Mamifero(string name, string color, int numberOfLegs) : base(name, color)
    {
        NumberOfLegs = numberOfLegs;
    }
    
    // Método virtual que pode ser usado pela própria classe e por outras classes derivadas
    public virtual void FeedYoung()
    {
        Console.WriteLine($"Mamifero {Name} está amamentando seus filhotes.");
    }
}
```

- **Descrição**: A classe `Mamifero` herda de `Animal` e adiciona a propriedade `NumberOfLegs`. O método `FeedYoung` é definido como virtual, permitindo que classes derivadas possam sobrescrevê-lo.

### Classe `Ave`

```csharp
public class Ave : Animal
{
    // Propriedade específica para aves
    public bool CanFly { get; set; }
    
    // Construtor padrão
    public Ave() { }

    // Construtor que inicializa propriedades de Ave e do Animal base
    public Ave(string name, string color, bool canFly) : base(name, color)
    {
        CanFly = canFly;
    }
    
    // Método virtual que pode ser usado e sobreescrito pela própria classe e por outras classes derivadas
    public virtual void Fly()
    {
        Console.WriteLine($"Ave {Name} está voando...");
    }
}
```

- **Descrição**: A classe `Ave` herda de `Animal` e adiciona a propriedade `CanFly`. O método `Fly` é definido como virtual, permitindo que classes derivadas forneçam uma implementação específica.

### Classe `Galinha`

```csharp
public class Galinha : Ave
{
    // Construtor padrão
    public Galinha() { }

    // Construtor que inicializa propriedades de Galinha e da classe base Ave
    public Galinha(string name, string color, bool canFly) : base(name, color, canFly) { }
    
    // Método que pode ser usado pela própria classe
    public void Scratch()
    {
        Console.WriteLine($"Galinha {Name} está siscando...");
    }
    
    // Método sobreescrito da classe Ave
    public override void Fly()
    {
        Console.WriteLine($"Galinha {Name} não pode voar!");
    }
    
    // Método sobreescrito da classe Animal
    public override void MakeNoise()
    {
        Console.WriteLine($"Galinha {Name} de cor {Color} faz o barulho de: pó pó pó...");
    }
    
    
}
```

- **Descrição**: A classe `Galinha` herda de `Ave` e sobrescreve os métodos `Fly` e `MakeNoise` para adaptar o comportamento às características específicas de uma galinha.

### Classe `Canguru`

```csharp
public class Canguru : Mamifero
{
    // Construtor padrão
    public Canguru() { }
    
    // Construtor que inicializa propriedades de Canguru e da classe base Mamifero
    public Canguru(string name, string color, int numberOfLegs) : base(name, color, numberOfLegs) { }

    // Método que pode ser usado pela própria classe
    public void Jump()
    {
        Console.WriteLine($"Canguru {Name} está pulando ... ");
    }

    // Método sobreescrito da classe Mamifero
    public override void FeedYoung()
    {
        Console.WriteLine($"Canguru {Name} não tem filhotes!");
    }
    
    // Método sobreescrito da classe Animal
    public override void MakeNoise()
    {
        Console.WriteLine($"Canguru {Name} de cor {Color} faz esse som ao pular: Thump, Thump, Thump...");
    }
}
```

- **Descrição**: A classe `Canguru` herda de `Mamifero` e sobrescreve os métodos `FeedYoung` e `MakeNoise` para personalizar o comportamento, demonstrando o conceito de polimorfismo.

### Uso das Classes

```csharp
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de Galinha e define suas propriedades
            Galinha chicken = new Galinha();

            // Propriedades herdados da classe Animal 
            chicken.Name = "Valentina";
            chicken.Color = "branca";
            
            // Propriedade herdada da classe Ave
            chicken.CanFly = false;
            
            // Executa o método herdado pela classe Animal
            chicken.MakeNoise();
            
            // Executa o método herdado pela classe Ave
            chicken.Fly();
            
            // Executa o método da própria classe
            chicken.Scratch();
            
            // --- 
            
            // Cria uma instância de Canguru usando o construtor com parâmetros herdados da classe Animal e Mamifero
            Canguru kangaroo  = new Canguru("Jack", "Marrom", 2);
            
            // Executa o método herdado da classe Animal
            kangaroo.MakeNoise();

            // Executa o método herdado da classe Mamifero
            kangaroo.FeedYoung();
            
            // Executa o método da própria classe
            kangaroo.Jump();
        }
    }
```

## Vantagens do Polimorfismo

- **Flexibilidade de Código**: Permite que uma função use objetos de diferentes classes da mesma hierarquia, adaptando seu comportamento conforme o tipo do objeto.


- **Reuso de Código**: Evita a duplicação de código, pois você pode definir um comportamento padrão na classe base e sobrescrevê-lo conforme necessário nas classes derivadas.


- **Extensibilidade**: Facilita a adição de novas classes à hierarquia, sem alterar o código existente que usa a classe base.

## Documentação Oficial 📚

Para mais detalhes sobre polimorfismo e outros conceitos de POO em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/polymorphism).
# Conceitos Básicos de POO em C# 🧩

[Código 💻](OOPBasics/Program.cs) Acesse o código aqui!

Este projeto demonstra os conceitos básicos de Programação Orientada a Objetos (POO) em C#, utilizando uma classe simples chamada `Pessoa`. O objetivo é ilustrar a criação de classes, uso de construtores, getters e setters (propriedades), e métodos em C#.

## O que é Programação Orientada a Objetos (POO)?

A Programação Orientada a Objetos (POO) é um paradigma de programação que utiliza "objetos" - que são instâncias de classes - para organizar o código de uma maneira que reflita o mundo real ou conceitos abstratos. POO facilita a reutilização de código, encapsulamento de dados, e modularidade.

## 1. Estrutura da Classe `Pessoa`

### **Declaração da Classe**

A classe `Pessoa` foi criada para representar uma pessoa com as seguintes propriedades:
- `FirstName`: O primeiro nome da pessoa.
- `LastName`: O sobrenome da pessoa.
- `Age`: A idade da pessoa.

```csharp
public class Pessoa
{
    public string FirstName;
    public string LastName;
    public int Age;
}
```

### **Construtores**

A classe `Pessoa` possui dois construtores:
- **Construtor Padrão**: Usado para criar uma instância da classe sem inicializar as propriedades.
- **Construtor Parametrizado**: Permite inicializar as propriedades da classe no momento da criação da instância.

```csharp
public Pessoa() { }

public Pessoa(string firstName, string lastName, int age)
{
    FirstName = firstName;
    LastName = lastName;
    Age = age;
}
```

### **Método `Walking`**

A classe também possui um método `Walking`, que imprime uma mensagem indicando que a pessoa está caminhando.

```csharp
public void Walking()
{
    Console.WriteLine($"{FirstName} {LastName} está caminhando!");
}
```

## 2. Uso da Classe `Pessoa`

O arquivo `Program.cs` demonstra como usar a classe `Pessoa`:

- **Instanciando Objetos**: Você pode criar uma instância da classe `Pessoa` usando o construtor padrão ou o construtor parametrizado.
- **Atribuindo Valores às Propriedades**: Após criar uma instância, você pode atribuir valores às suas propriedades.
- **Chamando Métodos**: O método `Walking` é chamado para mostrar que a pessoa está realizando uma ação.

```csharp
Pessoa p1 = new Pessoa();
p1.FirstName = "Leandro";
p1.LastName = "Ribeiro";
p1.Age = 33;

Pessoa p2 = new Pessoa("Bruna", "Martins", 38);

p1.Walking();
p2.Walking();
```

## 3. Documentação Oficial 📚

Para mais detalhes sobre Programação Orientada a Objetos em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/).

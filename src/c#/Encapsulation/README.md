# Encapsulamento em C# 🔒

Este projeto demonstra o conceito de encapsulamento em C# através da implementação de uma classe `Pessoa` com atributos privados e métodos públicos para acessar e modificar esses atributos. O encapsulamento é um dos princípios fundamentais da Programação Orientada a Objetos (POO), e consiste em esconder os detalhes internos de uma classe, expondo apenas o que é necessário através de métodos e propriedades públicas.

## O que é Encapsulamento?

Encapsulamento é a prática de restringir o acesso direto aos dados de um objeto, permitindo o acesso e modificação desses dados apenas por meio de métodos e propriedades controladas. Isso ajuda a proteger a integridade dos dados e a modularidade do código.

## Implementação

Neste exemplo, a classe `Pessoa` possui os seguintes atributos:

- `FirstName`: A propriedade é pública para leitura, mas seu valor só pode ser definido dentro da classe ou através do construtor.
- `LastName`: A propriedade pode ser lida e modificada publicamente.
- `Age`: O campo é privado, sendo acessível apenas através do método público `GetAge()`.

### Código de Exemplo

```csharp
namespace Encapsulation
{
    public class Pessoa
    {
        public string FirstName { get; private set; } 
        public string LastName { private get; set; }
        private int Age;

        // Construtor padrão
        public Pessoa() { }

        // Construtor com parâmetros para inicializar os atributos
        public Pessoa(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Método para obter a idade da pessoa
        public int GetAge()
        {
            return this.Age;
        }

        // Método para simular a ação de caminhar
        public void Walking()
        {
            Console.WriteLine($"{FirstName} {LastName} está caminhando!");
        }
    }
}
```

### Uso da Classe

```csharp
using Encapsulation;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe Pessoa com o construtor que aceita parâmetros
            Pessoa p = new Pessoa("Leandro", "Ribeiro", 33);
            
            // Modificando o sobrenome usando o setter público da propriedade LastName
            p.LastName = "Thiago";
            
            // Exibindo o primeiro nome e a idade usando o método GetAge() para acessar o campo privado Age
            Console.WriteLine($"{p.FirstName} tem {p.GetAge()} anos.");
            
            // Chamando o método Walking da classe Pessoa
            p.Walking();
        }
    }
}
```

## Vantagens do Encapsulamento

- **Proteção de Dados**: Ao encapsular os dados, você garante que eles não sejam modificados de maneira inadequada.


- **Facilidade de Manutenção**: Modificações na lógica interna da classe não afetam outras partes do código.


- **Modularidade**: Facilita a separação de responsabilidades e o entendimento do código.

## Documentação Oficial 📚

Para mais detalhes sobre encapsulamento e outros conceitos de POO em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/encapsulation).

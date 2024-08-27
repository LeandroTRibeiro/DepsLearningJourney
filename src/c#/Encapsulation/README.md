# Encapsulamento em C# 🔒

Este projeto demonstra o conceito de encapsulamento em C# através da implementação de uma classe `Pessoa` com atributos privados e métodos públicos para acessar e modificar esses atributos. O encapsulamento é um dos princípios fundamentais da Programação Orientada a Objetos (POO), e consiste em esconder os detalhes internos de uma classe, expondo apenas o que é necessário através de métodos e propriedades públicas.

## O que é Encapsulamento?

Encapsulamento é a prática de restringir o acesso direto aos dados de um objeto, permitindo o acesso e modificação desses dados apenas por meio de métodos e propriedades controladas. Isso ajuda a proteger a integridade dos dados e a modularidade do código.

## Implementação
Neste exemplo, a classe Pessoa demonstra diferentes formas de encapsulamento através do uso de propriedades e métodos. Abaixo, detalhamos o propósito e o nível de acesso de cada atributo:

- `FirstName`: A propriedade FirstName é pública para leitura, permitindo que qualquer código fora da classe obtenha o valor do nome. No entanto, a definição desse valor é restrita à própria classe ou ao construtor, garantindo que o nome não seja alterado de forma inadvertida após a criação do objeto.


- `LastName`: A propriedade LastName tem um acesso mais restritivo. Sua leitura é privada, o que significa que somente a própria classe pode acessar o valor internamente. Contudo, a propriedade pode ser modificada publicamente, permitindo que o sobrenome seja alterado por outros objetos ou métodos externos à classe.


- `Age`: Diferente dos outros atributos, Age é um campo privado. Isso significa que ele não pode ser acessado diretamente de fora da classe. Em vez disso, a idade só pode ser obtida através do método público GetAge(), oferecendo controle total sobre como e quando esse valor é exposto.

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

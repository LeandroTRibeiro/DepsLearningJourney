# Interfaces em C# 🛠️

[Código 💻](Interface/Program.cs) Acesse o código aqui!.

Este projeto demonstra o conceito de interfaces em C# através da implementação de diferentes métodos de pagamento. Uma interface define um contrato que as classes implementadoras devem seguir, garantindo que todas as classes que implementam a interface forneçam as funcionalidades definidas pela interface.

## O que é uma Interface?

Uma interface em C# é uma definição de contrato que contém a assinatura de métodos, propriedades, eventos ou indexadores, mas não contém implementação. As classes ou estruturas que implementam essa interface são obrigadas a fornecer uma implementação concreta para todos os membros definidos na interface. Interfaces permitem que você crie um código desacoplado e flexível, promovendo a reutilização e a facilidade de manutenção.

## Implementação

Neste exemplo, a interface `IPaymentMethod` define dois métodos: `ProcessPayment` e `GetPaymentInfo`. Três classes (`CreditCard`, `PayPal`, `BankTransfer`) implementam essa interface, cada uma fornecendo sua própria lógica para processar pagamentos e exibir informações sobre o pagamento.

### Interface `IPaymentMethod`

```csharp
namespace Interface;

public interface IPaymentMethod
{
    void ProcessPayment(decimal value); // Método para processar o pagamento
    void GetPaymentInfo();              // Método para exibir informações sobre o pagamento
}
```

- **Descrição**: A interface `IPaymentMethod` define o contrato que qualquer método de pagamento deve seguir. Ela exige que as classes implementem os métodos `ProcessPayment` e `GetPaymentInfo`.

### Classe `CreditCard`

```csharp
namespace Interface;

public class CreditCard : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via Credit Card to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via Credit Card\n");
    }
}
```

- **Descrição**: A classe `CreditCard` implementa a interface `IPaymentMethod` e fornece uma lógica específica para processar pagamentos via cartão de crédito.

### Classe `PayPal`

```csharp
namespace Interface;

public class PayPal : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via PayPal to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via PayPal\n");
    }
}
```

- **Descrição**: A classe `PayPal` implementa a interface `IPaymentMethod` e fornece uma lógica específica para processar pagamentos via PayPal.

### Classe `BankTransfer`

```csharp
namespace Interface;

public class BankTransfer : IPaymentMethod
{
    public void ProcessPayment(decimal value)
    {
        Console.WriteLine($"\nProcessing payment via Bank Transfer to: ${value}");
    }

    public void GetPaymentInfo()
    {
        Console.WriteLine("Payment made via Bank Transfer\n");
    }
}
```

- **Descrição**: A classe `BankTransfer` implementa a interface `IPaymentMethod` e fornece uma lógica específica para processar pagamentos via transferência bancária.

### Uso das Interfaces no Código Principal

```csharp
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de diferentes métodos de pagamento, todos implementando a interface IPaymentMethod
            List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>()
            {
                new CreditCard(),
                new PayPal(),
                new BankTransfer()
            };

            // Itera sobre a lista e processa o pagamento usando cada método
            foreach (IPaymentMethod paymentMethod in paymentMethods)
            {
                paymentMethod.ProcessPayment(100);
                paymentMethod.GetPaymentInfo(); 
            }
        }
    }
}
```

- **Descrição**: No método `Main`, uma lista de métodos de pagamento (`IPaymentMethod`) é criada, contendo diferentes implementações (`CreditCard`, `PayPal`, `BankTransfer`). O código itera sobre essa lista, processando e exibindo informações sobre o pagamento para cada método, independentemente de qual seja a implementação concreta.

## Vantagens de Usar Interfaces

- **Flexibilidade**: Interfaces permitem que diferentes classes compartilhem o mesmo contrato, mas com implementações distintas, o que facilita a extensão e a manutenção do código.


- **Desacoplamento**: Promovem um design desacoplado, onde o código que usa as interfaces não precisa conhecer os detalhes das implementações específicas.


- **Testabilidade**: Facilitam a criação de mocks ou stubs para testes unitários, permitindo que as implementações concretas sejam substituídas por versões simuladas.

## Documentação Oficial 📚

Para mais detalhes sobre interfaces e outros conceitos de Programação Orientada a Objetos (POO) em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/interfaces/).

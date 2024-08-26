# Métodos em C# 📋

[Código 💻](Methods/Program.cs) Acesse o código aqui!

Este projeto demonstra o uso de métodos em C#, abordando conceitos como soma de inteiros, contagem regressiva recursiva, cálculo de fatorial recursivo e a formatação de resultados.

## O que são Métodos?

Métodos em C# são blocos de código que realizam tarefas específicas e podem ser reutilizados em diferentes partes de um programa. Eles ajudam a organizar o código, tornando-o mais modular, legível e fácil de manter. Métodos podem receber parâmetros, retornar valores e serem chamados por outros métodos, permitindo a execução de tarefas de forma estruturada e eficiente.

## Estrutura de um Método
Um método em C# é composto por várias partes, que incluem:

- **Modificador de Acesso**: Define a visibilidade do método (por exemplo, `public`, `private`, `protected`, `internal`).


- **Tipo de Retorno**: Define o tipo de dado que o método irá retornar (por exemplo, `int`, `void`, `string`). Se o método não retorna nada, utiliza-se `void`.


- **Nome do Método**: Nome que identifica o método. Deve ser descritivo para indicar o que o método faz.


- **Parâmetros/Argumentos**: Valores que o método recebe para processar. São opcionais e, se presentes, ficam entre parênteses.


- **Corpo do Método**: Bloco de código delimitado por `{}` que contém as instruções que o método executa.

## 1. Exemplos de Métodos

### **Método `Sum`**

O método `Sum` recebe dois números inteiros como parâmetros, soma-os e retorna o resultado.

```csharp
static int Sum(int n1, int n2)
{
    return n1 + n2;
}
```

### **Método `Countdown`**

O método `Countdown` realiza uma contagem regressiva de forma recursiva, imprimindo os números no console.

```csharp
static void Countdown(int num)
{
    Console.WriteLine(num);

    if (num <= 1)
    {
        return;
    }
    else
    {
        Countdown(num - 1);
    }
}
```

### **Método `Fat`**

O método `Fat` calcula o fatorial de um número usando recursão e retorna o resultado.

```csharp
static int Fat(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * Fat(num - 1);
    }
}
```

### **Método `ShowFactorial`**

O método `ShowFactorial` recebe um número, calcula o seu fatorial usando o método `Fat`, e retorna uma string formatada com o resultado.

```csharp
static string ShowFactorial(int num)
{
    return $"O fatorial de {num} é {Fat(num)}!";
}
```

## 2. Documentação Oficial 📚

Para mais detalhes sobre métodos em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/methods).
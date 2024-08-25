# Laços de Interação 🔄

[Código 💻](LoopStructures/Program.cs) Acesse o código aqui!.

Este projeto demonstra o uso dos principais laços de interação em C#, incluindo `for`, `while`, `do-while`, e `foreach`. Além disso, ele ilustra como sair de laços de maneira controlada usando a instrução `break`.

## O que são Laços de Interação?
Laços de interação, também conhecidos como laços de repetição, são estruturas de controle de fluxo em programação que permitem a execução repetida de um bloco de código enquanto uma determinada condição é verdadeira ou até que uma condição específica seja atendida. Eles são fundamentais para realizar tarefas repetitivas de forma eficiente e são amplamente utilizados para iterar sobre coleções de dados, como arrays e listas.

## 1. Laços de Iteração

### **Laço `for`**

O laço `for` é utilizado quando você sabe de antemão quantas vezes o bloco de código deve ser executado. É ideal para iterar sobre arrays ou listas onde o número de elementos é conhecido.

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
```

### **Laço `while`**

O laço `while` é usado quando a execução do bloco de código depende de uma condição específica. Ele continua a execução enquanto a condição for verdadeira.

```csharp
int j = 0;
while (j < numbers.Length)
{
    Console.Write($"{numbers[j]} ");
    j++;
}
```

### **Laço `do-while`**

O laço `do-while` garante que o bloco de código seja executado pelo menos uma vez, pois a condição é verificada após a execução do bloco.

```csharp
int k = 0;
do
{
    Console.Write($"{numbers[k]} ");
    k++;
} while (k < numbers.Length);
```

### **Laço `foreach`**

O laço `foreach` é ideal para iterar sobre coleções como arrays e listas. Ele é usado quando você deseja acessar diretamente os elementos sem precisar de um índice.

```csharp
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
```

## 2. Saindo de Laços com `break`

A instrução `break` é usada para interromper a execução de um laço antes que ele complete todas as iterações. Isso é útil quando uma determinada condição é atendida, e você não precisa continuar a iteração.

```csharp
Console.WriteLine("\nMostrando todos elementos do array menores que 5 com o laço foreach: ");

foreach (int number in numbers)
{
    if (number >= 5)
    {
        break;
    }
    
    Console.Write($"{number} ");
}
```

Neste exemplo, o laço `foreach` é interrompido assim que um número maior ou igual a 5 é encontrado, evitando que números indesejados sejam processados.

## 3. Documentação Oficial 📚

Para mais detalhes sobre laços de interação em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/programming-guide/iterations/).

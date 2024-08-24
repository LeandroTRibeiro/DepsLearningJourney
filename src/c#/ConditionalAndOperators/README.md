# Estruturas Condicionais e Operadores 🔄

Este projeto apresenta exemplos de diversas estruturas condicionais e operadores em C#. Ele abrange o uso de `if`, `else if`, `else`, `switch`, operadores de comparação `>`, `<`, `==`, `!=`, `>=`, `<=`, operadores lógicos `&&`, `||`, `!`, operadores aritméticos `+`, `-`, `*`, `/`, `%`, `++`, `--`, e operadores ternários `?` `:`.

## 1. Instruções de Seleção

### `if`, `else if`, `else`

- A estrutura `if` permite executar um bloco de código se uma condição for verdadeira.
- A estrutura `else` executa um bloco de código se a condição no `if` for falsa.
- A estrutura `else if` permite verificar múltiplas condições.

```csharp
if (1 < 2)
{
    Console.WriteLine("1 < 2");
}

if (2 < 1)
{
    Console.WriteLine("2 < 1");
}
else
{
    Console.WriteLine("!(2 < 1)");
}

if (2 < 1)
{
    Console.WriteLine("2 < 1");
} 
else if (2 > 1)
{
    Console.WriteLine("2 > 1");
}
else
{
    Console.WriteLine("!(2 < 1)");
}
```

### `switch`

- A estrutura `switch` permite que você execute diferentes blocos de código com base no valor de uma expressão ou variável.
- Este exemplo utiliza o valor de `DayOfWeek` para determinar o dia da semana.

```csharp
int dayOfWeek = (int)DateTime.Today.DayOfWeek;

switch (dayOfWeek)
{
    case 0:
        Console.WriteLine("Sunday");
    break;
    case 1:
        Console.WriteLine("Monday");
    break;
    case 2:
        Console.WriteLine("Tuesday");
    break;
    case 3:
        Console.WriteLine("Wednesday");
    break;
    case 4:
        Console.WriteLine("Thursday");
    break;
    case 5:
        Console.WriteLine("Friday");
    break;
    case 6:
        Console.WriteLine("Saturday");
    break;
    default:
        Console.WriteLine("Invalid day!");
    break;
}
```

## 2. Operadores de Comparação

`==`, `!=`, `>`, `>=`, `<`, `<=` são usados para comparar valores.

```csharp
if (1 == 1)
{
    Console.WriteLine("1 == 1");
}

if (1 != 2)
{
    Console.WriteLine("1 != 2");
}

if (1 < 2)
{
    Console.WriteLine("1 < 2");
}

if (2 > 1)
{
    Console.WriteLine("2 > 1");
}

if (2 >= 2)
{
    Console.WriteLine("2 >= 2");
}

if (1 <= 1)
{
    Console.WriteLine("1 <= 1");
}
```

## 3. Operadores Lógicos

`&&`, `||`, `!` são operadores lógicos usados para combinar ou inverter condições.

```csharp
if (1 < 2 && 2 > 1)
{
    Console.WriteLine("1 < 2 && 2 > 1");
}

if (1 < 2 || 2 < 1)
{
    Console.WriteLine("1 < 2 || 2 < 1");
}

if (!(1 > 2))
{
    Console.WriteLine("!(1 > 2)");
}
```

## 4. Operadores Aritméticos

Os operadores aritméticos são usados para realizar operações matemáticas básicas, como adição, subtração, multiplicação, divisão e módulo. Também inclui operadores de incremento e decremento.

```csharp
int a = 10;
int b = 5;

int addition = a + b;
Console.WriteLine($"{a} + {b} = {addition}");

int subtraction = a - b;
Console.WriteLine($"{a} - {b} = {subtraction}");

int multiplication = a * b;
Console.WriteLine($"{a} * {b} = {multiplication}");

int division = a / b;
Console.WriteLine($"{a} / {b} = {division}");

int modulo = a % b;
Console.WriteLine($"{a} % {b} = {modulo}");

int increment = a;
increment++;
Console.WriteLine($"Incremento de {a} é {increment}");

int decrement = b;
decrement--;
Console.WriteLine($"Decremento de {b} é {decrement}");
```

## 5. Operadores Ternários

O operador ternário `?:` é uma forma abreviada de escrever um `if-else`.

```csharp
Console.WriteLine(true ? "true" : "false");

Console.WriteLine(false ? "true" : "false");
```

## 6. Documentação Oficial 📚

Para mais detalhes sobre estruturas condicionais e operadores em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements).
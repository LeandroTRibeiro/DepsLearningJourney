# Estruturas Condicionais e Operadores 🔄

Este projeto apresenta exemplos de diversas estruturas condicionais em C#. Ele abrange o uso de `if`, `else if`, `else`, `switch`, operadores de comparação `>`, `<`, `==`, `!=`, `>=`, `<=`, operadores lógicos `&&`, `||`, `!` e operadores ternários `?` `:`.

## Instruções de seleção

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

- A estrutura switch permite que você execute diferentes blocos de código com base no valor de uma expressão ou variável.
- Este exemplo utiliza o valor de DayOfWeek para determinar o dia da semana.

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

## Operadores de Comparação

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

## Operadores Lógicos

`&&`, `||`, `!` são operadores lógicos usados para combinar ou inverter condições.

```csharp
if (1 < 2 && 2 > 1)
{
    Console.WriteLine("1 < 2 && 2 > 1");
}

if (1 < 2 || 2 > 1)
{
    Console.WriteLine("1 < 2 || 2 < 1");
}

if (!(1 > 2))
{
    Console.WriteLine("!(1 > 2)");
}
```

## Operadores Ternários
O operador ternário `?:` é uma forma abreviada de escrever um `if-else`.

```csharp
Console.WriteLine(true ? "true" : "false");

Console.WriteLine(false ? "true" : "false");
```

## Documentação Oficial 📚

Para mais Para mais detalhes sobre estruturas condicionais em C#, consulte a [Documentação_Oficial]() do C#.

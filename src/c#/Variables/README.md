# Variables 🔠

Este projeto demonstra diferentes tipos de variáveis em C#, incluindo variáveis de instância, estáticas, privadas, locais, constantes, e o uso de variáveis com inferência de tipo (`var`). O código foi criado para ilustrar como cada tipo de variável é declarado, acessado e utilizado dentro de uma classe.

## Variáveis de Instância

Variáveis de instância são declaradas dentro de uma classe, mas fora de qualquer método. Elas são acessíveis em toda a classe, mas requerem uma instância da classe para serem usadas.

- Declaração:
```csharp
string globalInstanceVariable = "Global Instance Variable";
```
- Acesso:
```csharp
Program program = new Program();
Console.WriteLine($"Valor da variável de instância: {program.globalInstanceVariable}");
```

## Variáveis Estáticas

Variáveis estáticas são compartilhadas por todas as instâncias de uma classe. Elas são acessíveis sem precisar criar uma instância da classe.

- Declaração:
```csharp
static string globalStaticVariable = "Global Static Variable";
```

- Acesso:
```csharp
Console.WriteLine($"Valor da variável global estática: {globalStaticVariable}");
```

## Variáveis Privadas de Instância

Variáveis privadas são declaradas com o modificador private e só podem ser acessadas dentro da própria classe onde foram definidas. Elas ajudam a proteger os dados da classe.

- Declaração:
```csharp
private string privateVariable = "Private Variable";
```
- Acesso:
```csharp
Program program = new Program();
Console.WriteLine($"Valor da variável privada de instância: {program.privateVariable}");
```

## Variáveis Locais
Variáveis locais são declaradas dentro de métodos ou blocos de código e são acessíveis apenas dentro desse escopo. Elas não são visíveis fora do método onde foram criadas.

- Declaração:
```csharp
string localVariable = "Local Variable";
```

- Acesso:
```csharp
Console.WriteLine($"Valor da variável local: {localVariable}");
```

## Constantes

Constantes são valores que não podem ser alterados após a sua inicialização. Elas são declaradas com a palavra-chave const e devem ser inicializadas no momento da declaração.

- Declaração:
```csharp
const string constantVariable = "Constant Variable";
```

- Acesso:
```csharp
Console.WriteLine($"Valor da constante: {constantVariable}");
```

## Variáveis com Inferência de Tipo

O uso da palavra-chave `var` permite ao compilador inferir automaticamente o tipo da variável com base no valor atribuído. É uma maneira conveniente de declarar variáveis sem especificar explicitamente o tipo.

- Declaração:
```csharp
var inferredVariable = "Inferred Variable";
```

- Acesso:
```csharp
Console.WriteLine($"Valor da variável com inferência de tipo: {inferredVariable}");
```


## Documentação Oficial 📚

Para obter mais informações detalhadas sobre variáveis, e escopo de variáveis, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/declarations).

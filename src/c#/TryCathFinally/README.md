# `try-catch-finally` em C# 🛠️

[Código 💻](TryCatchFinally/Program.cs) Acesse o código aqui!

Este projeto demonstra o conceito de `try-catch-finally` em C# aplicado em uma requisição HTTP. Desta vez, além de explorar o tratamento de exceções, fizemos algo um pouco diferente, integrando conceitos de requisição a uma API, o que enriquece ainda mais o exemplo.

## O que é `try-catch-finally`?

O bloco `try-catch-finally` é uma construção em C# usada para tratar exceções, garantindo que o programa lide com erros de forma controlada e continue funcionando de maneira previsível. O bloco `try` contém o código que pode lançar uma exceção, o bloco `catch` trata qualquer exceção que ocorra, e o bloco `finally` é sempre executado, independentemente de uma exceção ter sido lançada ou não.

## Implementação

Neste exemplo, o código faz uma requisição HTTP GET para uma API pública que retorna uma lista de usuários em formato JSON. O projeto mostra como utilizar `try-catch-finally` para garantir que a requisição seja tratada corretamente e como exibir uma mensagem final de confirmação.

### Bloco `try`

```csharp
try
{
    using HttpClient client = new HttpClient();

    HttpResponseMessage response = await client.GetAsync(BASEURL);

    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();

    List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

    foreach (User user in users)
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"User id: {user.Id}");
        Console.WriteLine($"User name: {user.Name}");
        Console.WriteLine($"User username: {user.Username}");
        Console.WriteLine($"User email: {user.Email}");
        Console.WriteLine($"User Address.street: {user.Address.Street}");
        Console.WriteLine($"User Address.Suite: {user.Address.Suite}");
        Console.WriteLine($"User Address.City: {user.Address.City}");
        Console.WriteLine($"User Address.Zipcode: {user.Address.Zipcode}");
        Console.WriteLine($"User Address.Geo.Lat: {user.Address.Geo.Lat}");
        Console.WriteLine($"User Address.Geo.Lng: {user.Address.Geo.Lng}");
        Console.WriteLine($"User Phone: {user.Phone}");
        Console.WriteLine($"User Website: {user.Website}");
        Console.WriteLine($"User Company.Name: {user.Company.Name}");
        Console.WriteLine($"User Company.CatchPhrase: {user.Company.CatchPhrase}");
        Console.WriteLine($"User Company.Bs: {user.Company.Bs}");
        Console.WriteLine("------------------------------------------------------------");
    }
}
```

- **Descrição**: Neste bloco, o código tenta fazer uma requisição GET para a API, verifica se a resposta foi bem-sucedida, lê o conteúdo da resposta como uma string, desserializa o JSON em uma lista de objetos `User`, e então itera sobre essa lista para exibir as informações de cada usuário.

### Bloco `catch`

```csharp
catch (HttpRequestException e)
{
    Console.WriteLine($"\nException Caught! : {e.Message}");
}
```

- **Descrição**: Se ocorrer um erro durante a requisição HTTP, como problemas de rede ou uma URL inválida, este bloco `catch` captura a exceção do tipo `HttpRequestException` e exibe uma mensagem de erro no console, prevenindo que o programa falhe abruptamente.

### Bloco `finally`

```csharp
finally
{
    Console.WriteLine("\nThanks for using the API!.");
}
```

- **Descrição**: Este bloco é sempre executado, independentemente de uma exceção ter sido lançada ou não. É usado para garantir que a mensagem de agradecimento seja sempre exibida, encerrando a execução do programa de maneira limpa.

## Vantagens de Usar `try-catch-finally`

- **Tratamento de Erros**: Permite capturar e tratar exceções de forma controlada, prevenindo que o programa falhe de maneira inesperada.


- **Finalização Garantida**: O bloco `finally` garante que certos códigos sejam executados, mesmo que uma exceção ocorra, como liberar recursos ou exibir mensagens de conclusão.


- **Manutenção do Código**: Melhor manejo de erros torna o código mais robusto e facilita a manutenção e a depuração.

## Documentação Oficial 📚

Para mais detalhes sobre o uso de `try-catch-finally` em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-catch-finally).

---

Esse README destaca o propósito do projeto e oferece uma explicação clara e estruturada dos blocos `try-catch-finally`, além de integrar a parte de requisição HTTP para um exemplo mais rico e prático. Se precisar de mais alguma coisa, estou à disposição!
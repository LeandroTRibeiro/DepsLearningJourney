# `async` e `await` em C# 🐱

[Código 💻](AsyncAwait/Program.cs) Acesse o código aqui!

Este projeto explora o uso de `async` e `await` em C# para realizar operações assíncronas, como fazer uma requisição HTTP a uma API que retorna um fato sobre gatos. O exemplo também mostra como usar `try-catch-finally` para tratar exceções e garantir que uma mensagem final seja sempre exibida.

## O que são `async` e `await`?

Em C#, `async` e `await` são palavras-chave usadas para trabalhar com operações assíncronas, permitindo que o programa continue a execução sem esperar que uma operação demorada seja concluída.

- **`async`**: Indica que um método é assíncrono. Um método marcado como `async` permite o uso de `await` dentro dele, indicando que há operações que podem estar em andamento e serão finalizadas no futuro.

- **`await`**: Usado para "aguardar" a conclusão de uma operação assíncrona. Quando `await` é chamado, o controle é devolvido ao chamador do método até que a operação assíncrona seja concluída.

### Como Determinar Quando Um Método É Assíncrono?

- **Métodos Assíncronos**: Um método é considerado assíncrono quando ele é marcado com a palavra-chave `async` e retorna um `Task` ou `Task<T>`. Esses métodos permitem operações que podem estar em andamento e serem concluídas em um momento futuro, sem bloquear o fluxo do programa.

### Implementação

No exemplo abaixo, o código faz uma requisição HTTP GET para a API `https://catfact.ninja/fact`, que retorna um fato sobre gatos em formato JSON. A operação é feita de forma assíncrona para que o programa continue sendo executado enquanto espera pela resposta da API.

### Análise do Código

```csharp
using Newtonsoft.Json;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string BASEURL = "https://catfact.ninja/fact";

            try
            {
                // Criação do HttpClient para fazer a requisição HTTP
                HttpClient client = new HttpClient();

                // A palavra-chave 'await' é usada para esperar pela conclusão da requisição HTTP GET.
                // O controle é devolvido ao chamador do método até que a resposta seja recebida.
                HttpResponseMessage response = await client.GetAsync(BASEURL);

                // 'EnsureSuccessStatusCode' verifica se a requisição foi bem-sucedida,
                // e se não foi, lança uma exceção.
                response.EnsureSuccessStatusCode();

                // 'await' aqui permite que o programa espere até que a resposta seja lida completamente.
                string responseBody = await response.Content.ReadAsStringAsync();

                // Desserializa a resposta JSON em um objeto CatFact.
                CatFact catFact = JsonConvert.DeserializeObject<CatFact>(responseBody);

                // Exibe o fato sobre gatos no console.
                Console.WriteLine($"{catFact.Length} CatFact: {catFact.Fact}");

            }
            catch (HttpRequestException e)
            {
                // Captura e trata exceções que possam ocorrer durante a requisição HTTP.
                Console.WriteLine($"\nException Caught!: {e.Message}");
            }
            finally
            {
                // Bloco que sempre será executado, independentemente de sucesso ou falha.
                Console.WriteLine("\nThanks for learning about cats...");
            }
        }
    }
}
```

### Partes Cruciais do Código

- **`async Task Main(string[] args)`**:
    - O método `Main` é marcado com `async`, indicando que ele pode conter operações assíncronas. O retorno `Task` é necessário porque o método é assíncrono. `Task` representa o trabalho que está em andamento ou será concluído no futuro.


- **`await client.GetAsync(BASEURL)`**:
    - `await` é usado para "aguardar" a conclusão da requisição HTTP GET. Isso permite que o fluxo do programa continue em outro lugar enquanto espera pela resposta, sem bloquear a thread principal.


- **`await response.Content.ReadAsStringAsync()`**:
    - Novamente, `await` é utilizado para esperar até que o conteúdo da resposta seja completamente lido. Isso garante que o programa não tentará usar o conteúdo antes que ele esteja completamente disponível.


## Por que Usar `async` e `await`?

- **Eficiência**: Permite que o programa lide com tarefas assíncronas de forma eficiente, liberando recursos enquanto espera pela conclusão de operações demoradas.


- **Responsividade**: Em aplicativos com interface gráfica, `async` e `await` evitam o bloqueio da interface do usuário, mantendo a aplicação responsiva.



- **Facilidade de Manutenção**: O código assíncrono escrito com `async` e `await` é mais fácil de ler e manter, pois se parece com código síncrono, mas sem as complicações de callbacks ou manipulação de threads.



## Documentação Oficial 📚

Para mais informações sobre `async`, `await`, e o tratamento de exceções em C#, consulte a [Documentação Oficial do C#](https://learn.microsoft.com/dotnet/csharp/).

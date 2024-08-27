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
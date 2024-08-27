using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TryCathFinally
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string BASEURL = "https://jsonplaceholder.typicode.com/users/";
            /*WRONG URL*/ // string BASEURL = "https://jsonplaceholder.typicode.com/use";

            try
            {
                // Inicia o bloco try para executar a chamada HTTP.
                // Se algo der errado, o fluxo será passado para o bloco catch.
                
                using HttpClient client = new HttpClient();

                // Faz uma requisição GET para a URL especificada
                HttpResponseMessage response = await client.GetAsync(BASEURL);

                // Verifica se a resposta foi bem-sucedida (código de status 200-299).
                // Se o código de status for diferente, uma exceção é lançada.
                response.EnsureSuccessStatusCode();

                // Lê o conteúdo da resposta como uma string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Desserializa a string JSON para uma lista de objetos User
                List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                // Itera sobre a lista de usuários e exibe as informações de cada um no console
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
            catch (HttpRequestException e)
            {
                // O bloco catch captura qualquer exceção do tipo HttpRequestException,
                // que pode ocorrer se a requisição falhar, por exemplo, por um problema de rede ou uma URL inválida.
                // A mensagem de erro é então exibida no console.
                
                Console.WriteLine($"\nException Caught! : {e.Message}");
            }
            finally
            {
                // O bloco finally é sempre executado, independentemente de uma exceção ter sido lançada ou não.
                // Isso garante que a mensagem final seja sempre exibida, mesmo que ocorra um erro.
                
                Console.WriteLine("\nThanks for using the API!.");
            }
        }
    }
}

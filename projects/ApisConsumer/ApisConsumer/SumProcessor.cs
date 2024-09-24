namespace ApisConsumer;

public class SumProcessor
{
    public static async Task<SumModel> LoadSumInformationAsync(int comicNumber = 0)
    {
        string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today";

        using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {
                SumResultModel result = await response.Content.ReadAsAsync<SumResultModel>();
                
                return result.Results;
            }
            else
            {
                throw new Exception($"Error: {response.ReasonPhrase}");
            }
        }
        
        
    }

}
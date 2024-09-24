namespace ApisConsumer;

public class ComicProcessor
{
    public static async Task<ComicModel> LoadComicAsync(int comicNumber = 0)
    {
        string url = "";
        
        if (comicNumber > 0)
        {
            url = $"https://xkcd.com/{comicNumber}/info.0.json";
        }
        else
        {
            url = "https://xkcd.com/info.0.json";
        }

        using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {
                ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                
                return comic;
            }
            else
            {
                throw new Exception($"Error: {response.ReasonPhrase}");
            }
        }
        
        
    }
    
}
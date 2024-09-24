using System.Text.Json;
using ScreenSoundUsingApi.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response) ?? new List<Music>();
        
        MusicLibrary musicsLibrary = new(musics);

        // musicsLibrary.ShowAllMusics();
        
        // musicsLibrary.ShowMusicByGenre("rock");
        
        // musicsLibrary.ShowGenres();
        
        // musicsLibrary.ShowArtists();
        
        // musicsLibrary.ShowArtistsByGenre("rock");
        
        // musicsLibrary.ShowMusicsByArtist("P.O.D.");
        
        // musicsLibrary.ShowMusicsByTone("F#");
        
        FavoriteArtist favoriteArtist = new("Lista 1");
        
        favoriteArtist.AddArtist(musics.FirstOrDefault(music => music.Artist.Equals("U2")));
        favoriteArtist.AddArtist(musics.FirstOrDefault(music => music.Artist.Equals("U2")));
        
        favoriteArtist.ShowFavoriteArtist();
        
        favoriteArtist.CreateJson();
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"eita: {ex.Message}");
    }
}
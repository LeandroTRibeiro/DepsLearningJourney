using System.Text.Json;

namespace ScreenSoundUsingApi.Models;

public class FavoriteArtist
{
    public string Name { get; set; }
    public List<Music> FavoriteArtistList { get; set; }

    public FavoriteArtist(string name)
    {
        Name = name;
        FavoriteArtistList = new List<Music>();
    }

    public void AddArtist(Music music)
    {
        FavoriteArtistList.Add(music);
    }

    public void RemoveArtist(Music music)
    {
        FavoriteArtistList.Remove(music);
    }

    public void ShowFavoriteArtist()
    {
        Console.WriteLine($"Lista de Musica Favoritas: {Name}");

        foreach (Music music in FavoriteArtistList)
        {
            Console.WriteLine("\n");
            music.ShowMusic();
            Console.WriteLine("\n");
        }
    }

    public void CreateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
             name = Name,
             musics = FavoriteArtistList
        });

        string directory = "/home/leandro/LeandroTRibeiro/";
        string fileName = "favorite-artist.json";
        
        string fullPath = Path.Combine(directory, fileName);
        
        File.WriteAllText(fullPath, json);
        Console.WriteLine($"\nJson criado com sucesso! \nCaminho: {Path.GetFullPath(fileName)}");
    }
     
    
}
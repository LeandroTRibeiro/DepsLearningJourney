using System.Text.Json.Serialization;
using ScreenSoundUsingApi.Services;

namespace ScreenSoundUsingApi.Models;

public class Music
{
    private string[] _tones = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    
    [JsonPropertyName("song")]
    public string Name { get; set; }
    
    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    
    [JsonPropertyName("genre")]
    public string Genre { get; set; }
    
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tone
    {
        get
        {
            return _tones[Key];
        }
    }

    public void ShowMusic()
    {
        string duration = new FormatTime(Duration).GetTimeFormated();
        
        Console.WriteLine($"Musica: {Name}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Duração: {duration}");
        Console.WriteLine($"Genero: {Genre}");
        Console.WriteLine($"Tonalidade: {Tone}");
    }
}
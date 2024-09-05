namespace ScreenSoundOOP;

public class Music
{
    public string Name { get; set; }
    private string _artist;
    public int Duration { get; set; }
    public bool Available { get; private set; }
    
    public Genero Genero { get; set; }

    private string _musicResume;

    public string MusicResume
    {
        get
        {
            return $"A musica {Name} pertence ao artista {_artist}.";
        }
    }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {_artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine(Available ? "Available: sim" : "Not available");
    }
}
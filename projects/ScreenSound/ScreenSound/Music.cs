namespace ScreenSound;

public class Music
{
    public string Name { get; set; }
    private string _artist;
    private int _duration;
    public bool Available { get; private set; }

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
        Console.WriteLine($"Duration: {_duration}");
        Console.WriteLine(Available ? "Available: sim" : "Not available");
    }
    
}
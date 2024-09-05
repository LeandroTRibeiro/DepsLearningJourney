namespace ScreenSoundOOP;

public class Album
{
    private List<Music> _musics = new List<Music>();
    public string Name { get; set; }
    public int Duration => _musics.Sum(x => x.Duration); 
    
    public void AddMusic(Music music)
    {
        _musics.Add(music);
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Lista de musicas do album {Name}: ");
        foreach (Music music in _musics)
        {
            Console.WriteLine($"Musica: {music.Name}");
        }
        Console.WriteLine($"Duracao do album: {Duration}s");
    }

}
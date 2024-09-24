namespace ScreenSoundUsingApi.Models;

public class MusicLibrary
{
    private List<Music> _musics;
    private Dictionary<string, List<Music>> _musicDictionary = new Dictionary<string, List<Music>>();

    public MusicLibrary(List<Music> musics)
    {
        _musics = musics;
        
        foreach (Music music in _musics)
        {
            if(string.IsNullOrWhiteSpace(music.Genre)) continue;
            if (!_musicDictionary.ContainsKey(music.Genre))
            {
                _musicDictionary[music.Genre] = new List<Music>();
            }
            
            _musicDictionary[music.Genre].Add(music);
        }
    }

    public void ShowAllMusics()
    {
        Console.WriteLine("All musics - ");
        foreach (Music music in _musics)
        {
            Console.WriteLine("\n");
            music.ShowMusic();
            Console.WriteLine("\n");
        }
    }

    public void ShowMusicByGenre()
    {
        foreach (var genre in _musicDictionary)
        {
            Console.WriteLine("\n");
            Console.WriteLine("==========================================");
            Console.WriteLine("\n");
            Console.WriteLine($"Genero: {genre.Key}");

            foreach (var music in genre.Value)
            {
                Console.WriteLine("\n");
                music.ShowMusic();
                Console.WriteLine("\n");
            }
        }
    }
    
    public void ShowMusicByGenre(string genre)
    {
        Console.WriteLine("\n");
        Console.WriteLine("==========================================");
        Console.WriteLine("\n");
        Console.WriteLine($"Genero: {genre}");

        foreach (var music in _musicDictionary[genre])
        {
            Console.WriteLine("\n");
            music.ShowMusic();
            Console.WriteLine("\n");
        }
    }

    public void ShowGenres()
    {
        var genres = _musics.Select(music => music.Genre).Distinct().ToList();

        foreach (var genre in genres)
        {
            Console.WriteLine($"{genre}");
        }
    }
    
    public void ShowArtists()
    {
        var artists = _musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
        
        foreach (var artist in artists)
        {
            Console.WriteLine($"{artist}");
        }
    }
    public void ShowArtistsByGenre(string genre)
    {
        var artists = _musics.Where(music => music.Genre.Contains(genre)).Select(music => music.Artist).OrderBy(music => music).Distinct().ToList();
        
        foreach (var artist in artists)
        {
            Console.WriteLine($"{artist}");
        }
    }

    public void ShowMusicsByArtist(string artist)
    {
        var musics = _musics.Where(music => music.Artist.Equals(artist)).Select(music => music.Name).OrderBy(music => music).ToList();
        
        Console.WriteLine($"{artist}");
        foreach (var music in musics)
        {
            Console.WriteLine($"{music}");
        }
    }

    public void ShowMusicsByTone(string tone)
    {
        var musics = _musics.Where(music => music.Tone.Equals(tone));

        foreach (var music in musics)
        {
            Console.WriteLine("\n");
            music.ShowMusic();
            Console.WriteLine("\n");
        }
    }
    
}
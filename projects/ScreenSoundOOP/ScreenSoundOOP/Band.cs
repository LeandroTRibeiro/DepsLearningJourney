namespace ScreenSoundOOP;

public class Band
{
    private List<Album> _albums = new List<Album>();
    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void ShowDiscographie()
    {
        Console.WriteLine("Lista de Albums da banda: ");
        foreach (Album album in _albums)
        {
            Console.WriteLine($"Album: {album.Name}");
        }
    }
}
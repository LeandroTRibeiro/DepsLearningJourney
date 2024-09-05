namespace ScreenSoundOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Album queenAlbum = new Album();
            
            queenAlbum.Name = "A night at the opera";
            Music music1 = new Music();
            music1.Name = "Love of my life";
            music1.Duration = 213;
            
            Music music2 = new Music();
            music2.Name = "Bohemian Rhapsody";
            music2.Duration = 354;
            queenAlbum.AddMusic(music1);
            queenAlbum.AddMusic(music2);
            
            queenAlbum.ShowAlbumMusics();        
        }
    }
}
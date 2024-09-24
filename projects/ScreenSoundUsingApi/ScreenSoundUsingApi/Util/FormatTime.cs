namespace ScreenSoundUsingApi.Services;

public class FormatTime
{
    private TimeSpan _timeSpan;
    
    public FormatTime(int timeSpan)
    {
        SetTime(timeSpan);
    }
    
    public void SetTime(int timeSpan)
    {
        if (timeSpan < 0) 
            throw new ArgumentException("A funcao deve receber um valor positivo de milisegundos.");
        
        _timeSpan = TimeSpan.FromMilliseconds(timeSpan);
    }

    public string GetTimeFormated()
    {
        int hour = _timeSpan.Hours;
        int minute = _timeSpan.Minutes;
        int second = _timeSpan.Seconds;

        return $"{hour:D2}:{minute:D2}:{second:D2}";
    }
}
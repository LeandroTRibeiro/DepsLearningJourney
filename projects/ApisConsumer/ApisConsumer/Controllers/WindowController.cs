using Microsoft.AspNetCore.Mvc;

namespace ApisConsumer.Controllers;

[ApiController]
[Route("api/")]
public class WindowController : ControllerBase
{
    
    [HttpGet("page/{imageNumber}")]
    public async Task<string> LoadImage(int imageNumber = 0)
    {
        var comic = await ComicProcessor.LoadComicAsync(imageNumber);
        
        return comic.Img;
    }
}
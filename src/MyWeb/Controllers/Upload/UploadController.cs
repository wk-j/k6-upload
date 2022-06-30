using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers.Uplaod;

public record Info(
    string Id,
    IFormFile File
);

[ApiController]
[Route("api/[controller]/[action]")]
public class UploadController : ControllerBase
{

    [HttpPost]
    public IActionResult Upload([FromForm] Info info)
    {
        Console.WriteLine(info.File.Length);
        return Ok();
    }
}
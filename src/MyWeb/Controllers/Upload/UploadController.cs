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
    public IActionResult Upload([FromForm] Info info, [FromServices] ILogger<UploadController> logger)
    {
        logger.LogInformation($"{info.File.Name} {info.File.Length / 1024.0 / 1024.0}");
        return Ok();
    }
}
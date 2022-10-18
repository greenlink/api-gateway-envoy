using Microsoft.AspNetCore.Mvc;

namespace CatApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CatController : ControllerBase
{
    private static readonly string[] CatRaces = new[]
    {
        "Abyssinian", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Balinese-Javanese", "Bengal", "Birman"
    };

    private readonly ILogger<CatController> _logger;

    public CatController(ILogger<CatController> logger) => _logger = logger;

    [HttpGet]
    public ActionResult Get()
    {
        var random = new Random();
        return Ok(CatRaces[random.Next(CatRaces.Length)]);
    }
}

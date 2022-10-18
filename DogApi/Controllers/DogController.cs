using Microsoft.AspNetCore.Mvc;

namespace DogApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DogController : ControllerBase
{
    private static readonly string[] DogRaces = new[]
    {
        "Affenpinscher", "Afghan Hound", "Africanis", "Aidi", "Airedale Terrier", "Akbash", "Akita", "Aksaray Malaklisi",
        "Alano Español", "Alapaha Blue Blood Bulldog", "Alaskan husky", "Alaskan Klee Kai", "Alaskan Malamute", "Alopekis"
    };

    private readonly ILogger<DogController> _logger;

    public DogController(ILogger<DogController> logger) => _logger = logger;

    [HttpGet]
    public ActionResult Get()
    {
        var random = new Random();
        return Ok(DogRaces[random.Next(DogRaces.Length)]);
    }
}

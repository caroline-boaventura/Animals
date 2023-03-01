using Microsoft.AspNetCore.Mvc;

namespace Animals.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly ILogger<AnimalsController> _logger;

    public AnimalsController(
        ILogger<AnimalsController> logger
    )
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<string> GenerateAnimals([FromBody] AnimalsRequest request)
    {
        try
        {
            // return await _animalsService.GenerateAnimals(request.Quantity);
            return request.Quantity.ToString();
        }
        catch (System.Exception e)
        {
            throw new Exception($"Error: {e.Message}");
        }
    }

    [HttpGet]
    public string GetAnimals([FromHeader] string token)
    {
        return "teste";
        // return _animalsService.GetAnimals(token);
    }
}

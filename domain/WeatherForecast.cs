
using domain;
using Microsoft.AspNetCore.Mvc;
using domain;
using Persistence;
namespace API.Controllers;
[ApiController]
[Route("[controller")]

public class WeatherForecast : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing","Chilly","Cool","Mild","Warm","Balmy","Hot","Sweltering","Scorching";

    }

    private readonly ILogger<WeatherForeCastController>_logger;
    private readonly DataContext _context;
    public WeatherForeCastController(ILogger<WeatherForeCastController> logger,DataContext _context)
    {
        _logger = logger;_context=context;

    }
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
[Httppost]
public ActionResult<WeatherForeCast> Create()
{
    Console.WriteLine($"Database path:{_context.DbPath}");
    Console.WriteLine("Insert a new WeatherForecast");

    var forecast = new WeatherForeCast()
    {
        Date = new DateTime(),
        TemperatureC = 75,
        Summary = "Warm"
    };
    _context.WeatherForeCasts.Add(forecast);
    var success = _context.SaveChanges() > 0;
    if(success)
    {
        return forecast;
    }
    throw new exception("Error creating Weatherforecast");
    
}

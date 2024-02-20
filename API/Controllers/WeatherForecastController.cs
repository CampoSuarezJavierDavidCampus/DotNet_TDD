using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class WeatherForecastController(ILogger<WeatherForecastController> logger) :ApiBaseController
{
    private static readonly string[] Summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Getting weatherforecast...");
        var rng = new Random();
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        })
        .ToArray();

    }
}

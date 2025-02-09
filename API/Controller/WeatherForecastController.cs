using Domain.Model.Weather;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
  public class WeatherForecastController : BaseControllerApp
  {

    string[] summaries = new[]
    {
        "Freezing", "Bracing",
        "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot",
        "Sweltering", "Scorching"
    };

    [HttpGet("GetCollectionWeatherForecast")]
    public WeatherForecast[] GetCollectionWeatherForecast()
    {
      var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return forecast;
    }

    [HttpGet("GetCollectionWeatherForecast/{count}")]
    public WeatherForecast[] GetCollectionWeatherForecast(int count)
    {
      var forecast = Enumerable.Range(1, count).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return forecast;
    }

    [HttpPost]
    [Route("Post")]
    public WeatherForecast[] Post()
    {
      var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return forecast;
    }
  }
}
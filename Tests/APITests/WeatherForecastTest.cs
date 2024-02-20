using API.Controllers;
using Microsoft.Extensions.Logging;
namespace Tests.APITests;

public class WeatherForecastTest
{
    [Fact]
    public void GetWeatherForecast()
    {
        //Arrange
        var mock = new Mock<ILogger<WeatherForecastController>>();
        var controller = new WeatherForecastController(mock.Object);
        //Act
        var res = controller.Get();
        //Assert
        Assert.NotNull(res);
        Assert.Equal(5, res.Count());
    }

    [Fact]
    public void GetWeatherForecast_ItemValue()
    {
        //Arrange
        var mock = new Mock<ILogger<WeatherForecastController>>();
        var controller = new WeatherForecastController(mock.Object);
        //Act
        var res = controller.Get().ToList()[0];
        //Assert
        Assert.NotNull(res);
        Assert.NotEmpty(res.Summary);
        Assert.True(res.TemperatureC > -20);
        Assert.True(res.Date > new DateTime());
    }
}

using ProjectManagementSystem.Models;
using System.Collections.Generic;

namespace ProjectManagementSystem.Providers
{
    /// <summary>
    /// Weather provider.
    /// </summary>
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}

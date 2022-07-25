using Observer.DisplayElements;
using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.setMeasurments(80,65,35.42f);
            weatherData.setMeasurments(80, 75, 32.32f);
        }
    }
}

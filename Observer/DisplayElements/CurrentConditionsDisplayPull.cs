using Observer.Observers;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DisplayElements
{
    public class CurrentConditionsDisplayPull : DisplayElement, ObserverPullInterface
    {
        private float _temperature;
        private float _humidity;
        private float _presure;
        private Subject _weatherData;

        public CurrentConditionsDisplayPull(Subject weateherData)
        {
            _weatherData = weateherData;
            //_watherData.register(this);
        }
        public void display()
        {
            Console.WriteLine($"Current codition temp: {_temperature} C degrees, humidity {_humidity}, pressure {_presure}");
        }
        public void update(Subject subj)
        {
            //we can add optional parameter with default null, which represen if is null -> pull, otherwise is push observer.
            var weatherData = subj as WeatherData;
            if(weatherData != null)
            {
                _temperature = weatherData.Temperature;
                _humidity = weatherData.Humidity;
                _presure = weatherData.Pressure;
                display();
            }
        }
    }
}

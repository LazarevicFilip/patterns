using Observer.Observers;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DisplayElements
{
    public class StatisticsDisplay : DisplayElement, ObserverInterface
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private Subject _weatherData;
        public StatisticsDisplay(Subject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.register(this);
        }
        public void display()
        {
            Console.WriteLine($"Min/Max/Avg : {minTemperature().ToString()}/{maxTemperature().ToString()}/{_temperature.ToString()}");
        }

        public float minTemperature()
        {
            return _temperature - 5;
        }
        public float maxTemperature()
        {
            return _temperature + 5;
        }
        public void update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            display();
        }
    }
}

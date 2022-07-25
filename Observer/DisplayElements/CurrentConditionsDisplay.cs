using Observer.Observers;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DisplayElements
{
    public class CurrentConditionsDisplay : DisplayElement, ObserverInterface
    {
        private float _temperature;
        private float _humidity;
        private float _presure;
        private Subject _watherData;

        public CurrentConditionsDisplay(Subject watherDate)
        {
            _watherData = watherDate;
            _watherData.register(this);
        }
        public void display()
        {
            Console.WriteLine($"Current codition temp: {_temperature} C degrees, humidity {_humidity}, pressure {_presure}");
        }

        public void update(float temp, float humidity, float pressure)
        {
           _temperature = temp;
            _humidity = humidity;
            _presure = pressure;
            display();
        }
    }
}

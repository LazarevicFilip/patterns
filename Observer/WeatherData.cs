using Observer.Observers;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherData : Subject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private List<ObserverInterface> _observers = new List<ObserverInterface>();

        public float Temperature  => _temperature;
        public float Humidity => _humidity;
        public float Pressure => _pressure;

        public WeatherData() { }

        public void notifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.update(Temperature, Humidity, Pressure);
            }
        }

        public void register(ObserverInterface o)
        {
            _observers.Add(o);
        }

        public void remove(ObserverInterface o)
        {
            var index = _observers.IndexOf(o);
            if(index > -1)
                _observers.Remove(o);
        }
        public void measurmentsChanged()
        {
            notifyObservers();
        }
        public void setMeasurments(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            measurmentsChanged();
        }
        
    }
}

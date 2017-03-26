using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2___ObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void UnregisterObserver(IObserver o);
        void NotifyObservers();
    }

    public class WeatherStation : ISubject
    {
        protected IList<IObserver> Observers = new List<IObserver>();
        protected double Temperature, Humidity, Pressure;

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void UnregisterObserver(IObserver o)
        {
            Observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void SetMeasurements(double t, double h, double p)
        {
            this.Temperature = t;
            this.Humidity = h;
            this.Pressure = p;
            NotifyObservers();
        }
    }
}

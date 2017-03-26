using System;

namespace Chapter_2___ObserverPattern
{
    public interface IObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }

    public class CurrentConditionsDisplay : IObserver
    {
        protected double Temperature, Humidity, Pressure;

        public void Update(double t, double h, double p)
        {
            Temperature = t;
            Humidity = h;
            Pressure = p;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions Display: {0}C - {1}% - {2}Bars" , Temperature, Humidity, Pressure);
        }
    }

    public class AirplaneSafetyMonitor : IObserver
    {
        protected double Temperature, Humidity, Pressure;

        public void Update(double t, double h, double p)
        {
            Temperature = t;
            Humidity = h;
            Pressure = p;
            Display();
        }

        public void Display()
        {
            if (Pressure < 100)
            {
                Console.WriteLine("Air Safety Monitor: AIR PRESSURE TOO HIGH FOR LAUNCH.");
            }
            else
            {
                {
                    Console.WriteLine("Air Safety Monitor: Conditions Suitable for Launch.");
                }
            }
        }
    }
}

using System;
using System.Collections;

namespace Chapter_2___ObserverPattern
{
    public interface IObserver
    {
        void Update(string Location, double temperature, double humidity, double pressure);
    }

    public class CurrentConditionsDisplay : IObserver
    {
        protected double Temperature, Humidity, Pressure;

        public void Update(string Location, double t, double h, double p)
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

        public void Update(string Location, double t, double h, double p)
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

        //Finding New Uses for the Weather Station Data.
        public class TripAdvisor : IObserver
        {
            string Location;
            double AverageTemp;
            int rating;
            protected double Temperature, Humidity, Pressure;
            ArrayList temperatureList = new ArrayList();
            ArrayList humidityList = new ArrayList();
            ArrayList pressureList = new ArrayList();

            public void Update(string Location, double t, double h, double p)
            {
                this.Location = Location;
                temperatureList.Add(t);
                Display();
            }

            public void Display()
            {
                Console.WriteLine("Trip Advisor Collecting Data from Location: {0}", Location);
            }
            public void TripAdvisorWeatherRating()
            {   
                
                Console.WriteLine("Trip Advisor: Gives {0} a {1} Star Rating.", Location, GetRating());
            }
            public int GetRating()
            {
                foreach (double value in temperatureList)
                {
                    AverageTemp = AverageTemp + value;
                }
                AverageTemp = (AverageTemp / temperatureList.Count);

                if(AverageTemp < 10)
                {
                    rating = 1;
                }
                else if(AverageTemp < 15)
                {
                    rating = 2;
                }
                else if (AverageTemp < 20)
                {
                    rating = 3;
                }
                else if(AverageTemp < 25)
                {
                    rating = 4;
                }
                else if(AverageTemp < 10)
                {
                    rating = 5;
                }
                return rating;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2___ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Chapter 2 - Observer Pattern:");

            //Subject
            WeatherStation weatherStation = new WeatherStation();

            //Observers
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay();
            AirplaneSafetyMonitor airplaneSafetyMonitor = new AirplaneSafetyMonitor();

            //Register Observer to Subject
            weatherStation.RegisterObserver(currentConditions);
            weatherStation.RegisterObserver(airplaneSafetyMonitor);

            weatherStation.SetMeasurements(22, 77, 112);


			Console.ReadKey();
		}
	}
}

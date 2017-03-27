using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter_2___ObserverPattern.AirplaneSafetyMonitor;

namespace Chapter_2___ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Chapter 2 - Observer Pattern:");

            //Subject
            Console.WriteLine("Creating Subject - Weather Station:\n");
            WeatherStation weatherStation = new WeatherStation();

            //Observers
            Console.WriteLine("Creating Observers - CurrentConditionsDisplay, AirplanSafetyMonitor & Trip Advisor: \n");
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay();
            AirplaneSafetyMonitor airplaneSafetyMonitor = new AirplaneSafetyMonitor();
            TripAdvisor tripAdvisor = new TripAdvisor();

            //Register Observer to Subject
            Console.WriteLine("Reistering Observers to Recieve Weather Station Data: \n");
            weatherStation.RegisterObserver(currentConditions);
            weatherStation.RegisterObserver(airplaneSafetyMonitor);
            weatherStation.RegisterObserver(tripAdvisor);

            //Setting Measurements
            Console.WriteLine("Setting Measurements @ Weather Station:");
            weatherStation.SetMeasurements("Wicklow Way", 22, 77, 112);

            tripAdvisor.TripAdvisorWeatherRating();


			Console.ReadKey();
		}
	}
}

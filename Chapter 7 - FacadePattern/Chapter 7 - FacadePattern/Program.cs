using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 7 - Facade Pattern:");

            //Appliances
            Light light = new Light();
            Projector projector = new Projector();
            AudioAmplifier audioAmp = new AudioAmplifier();
            PopcornMaker popcornMaker = new PopcornMaker();

            //Theatre Facade Object
            HomeTheatreFacade homeTheatre = new HomeTheatreFacade(light, projector, audioAmp, popcornMaker);

            //Interact with Facade
            homeTheatre.PrepareMovie();
            homeTheatre.WatchMovie();
            homeTheatre.TurnOff();

            Console.ReadKey();
        }
    }
}

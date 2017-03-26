using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___FacadePattern
{
    public class HomeTheatreFacade
    {
        private Light light;
        private Projector projector;
        private AudioAmplifier audioAmplifier;
        private PopcornMaker popcornMaker;

        public HomeTheatreFacade(Light light, Projector projector, AudioAmplifier audioamp, PopcornMaker popcornMaker)
        {
            this.light = light;
            this.projector = projector;
            this.audioAmplifier = audioamp;
            this.popcornMaker = popcornMaker;
        }

        public void PrepareMovie()
        {
            Console.WriteLine("-----------Preparing Theatre:-----------");
            popcornMaker.TurnOn();
            projector.WarmUp();
            audioAmplifier.SoundCheck();
            
        }

        public void WatchMovie()
        {
            Console.WriteLine("-----------Playing Movie--------------");
            popcornMaker.TurnOff();
            light.TurnOff();
            projector.TurnOn();
            audioAmplifier.TurnOn();
        }

        public void TurnOff()
        {
            Console.WriteLine("-----------Turning Off Home Threatre--------------");
            projector.TurnOff();
            audioAmplifier.TurnOff();
        }
    }
}

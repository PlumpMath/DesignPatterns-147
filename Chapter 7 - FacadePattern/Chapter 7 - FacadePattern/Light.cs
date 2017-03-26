using System;
using System.Security.Cryptography.X509Certificates;

namespace Chapter_7___FacadePattern
{
    //Appliances
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning ON Lights.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF Lights");
        }
    }

    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning ON Projector");
        }
        public void WarmUp()
        {
            Console.WriteLine("Warming Up Projector Bulb.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF projector.");
        }
    }

    public class AudioAmplifier
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF Audio Amplifier");
        }
        public void TurnOn()
        {
            Console.WriteLine("Turning ON Audio Amplifier");
        }
        public void SoundCheck()
        {
            Console.WriteLine("Calibrating Audio Amplifier");
        }
    }

    public class PopcornMaker
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning ON Popcorn Maker 5000 - Caution Hot Oil!");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning OFF Popcorn Maker 5000");
        }
    }
}
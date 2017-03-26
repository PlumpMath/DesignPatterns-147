using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6___CommandPattern
{
    //Applicances
    public class Light
    {
        public string Location { get; set; }

        public void TurnOn()
        {
            Console.WriteLine(Location + " Light is ON.");
        }
        public void TurnOff()
        {
            Console.WriteLine(Location + " Light is OFF.");
        }
    }

    public class CeilingFan
    {
        public string Location { get; set; }
        public int Speed { get; set; }

        public void High()
        {
            Speed = 3;
            Console.WriteLine(Location + " Ceiling Fan on High.");
        }
        public void Medium()
        {
            Speed = 2;
            Console.WriteLine(Location + " Ceiling Fan on Medium.");
        }

        public void Low()
        {
            Speed = 1;
            Console.WriteLine(Location + " Ceiling Fan on Low.");
        }

        public void Off()
        {
            Speed = 0;
            Console.WriteLine(Location + " Ceiling Fan is Off.");
        }
    }

    public class Stereo
    {
        public string Album { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Stereo is Turned On, resuming " + Album);
        }
        public void TurnOff()
        {
            Console.WriteLine("Stereo is Turned Off.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11___ProxyPattern
{
    public class GumballMachine
    {
        private string Location;
        private int Count;

        public GumballMachine(string location, int count)
        {
            Location = location;
            Count = count;
        }

        public string GetLocation()
        {
            return Location;
        }
        public int GetCount()
        {
            return Count;
        }

        public GumballState GetGumballState()
        {
            //Returning Simple State to keep code base small.
            return new HasQuarterState();
        }
    }

    public class GumballMonitor
    {
        private GumballMachine Machine;

        public GumballMonitor(GumballMachine machine)
        {
            Machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine @ {0}" , Machine.GetLocation());
            Console.WriteLine("Current Inventory: {0}", Machine.GetCount());
            Console.WriteLine("Current State: {0}", Machine.GetGumballState().GetType().Name);
        }
    }
}

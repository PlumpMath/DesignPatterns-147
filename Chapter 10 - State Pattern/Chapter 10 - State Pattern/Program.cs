using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10___State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 10 - State Pattern:");

            GumballMachine machine = new GumballMachine(10);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.Dispense();

            machine.SetCount(0);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.Dispense();

            machine.Refill(10);

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.Dispense();



            Console.ReadKey();
        }
    }
}

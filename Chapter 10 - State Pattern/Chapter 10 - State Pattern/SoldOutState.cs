using System;

namespace Chapter_10___State_Pattern
{
    public class SoldOutState : GumballState
    {
        //Instance of Machine
        private GumballMachine Machine;

        public SoldOutState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Not Accepting Quarter, We're SOLD OUT!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No Quarter to Eject!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("No Quarter, blocking Turn Crank Action!");
        }

        public void Dispense()
        {
            Console.WriteLine("Cannot Dispense from SOLD_OUT State.");
        }

        //Method Exclusive to SoldOutState
        public void Refill(int gumballs)
        {
            if (gumballs > 0)
            {
                //Set Machin Gum Balls
                Machine.SetCount(gumballs);
                //Transition State to back in action
                Machine.SetGumballState(Machine.GetNoQuarterState());
            }
        }
    }
}

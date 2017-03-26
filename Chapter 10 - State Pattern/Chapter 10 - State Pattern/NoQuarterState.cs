using System;

namespace Chapter_10___State_Pattern
{
    public class NoQuarterState : GumballState
    {
        //Instance of Machine
        private GumballMachine Machine;

        public NoQuarterState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter Inserted!");
            Machine.SetGumballState(Machine.GetHasQuarterState());
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
            Console.WriteLine("Cannot Dispense from NO_Quarter State.");
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Refill(int gumballs)
        {
            throw new NotImplementedException();
        }
    }
}

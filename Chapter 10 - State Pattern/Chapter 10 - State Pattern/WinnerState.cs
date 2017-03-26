using System;

namespace Chapter_10___State_Pattern
{
    public class WinnerState : GumballState
    {
        private GumballMachine Machine;

        public WinnerState(GumballMachine machine)
        {
            Machine = machine;
        }
        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            Console.WriteLine("CONGRATULATIONS, WE HAVE A WINNER!");
            Console.WriteLine("Releasing Free Gumball!");
            if (Machine.GetCount() == 0)
            {
                Machine.SetGumballState(Machine.GetSoldOutState());
            }
            else
            {
                Console.WriteLine("Releasing Gumball!");
                if (Machine.GetCount() > 0)
                {
                    Machine.SetGumballState(Machine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Ooops, out of Gumballs...");
                    Machine.SetGumballState(Machine.GetSoldOutState());
                }
            }
        }

        public void Refill(int gumballs)
        {
            throw new NotImplementedException();
        }
    }
}
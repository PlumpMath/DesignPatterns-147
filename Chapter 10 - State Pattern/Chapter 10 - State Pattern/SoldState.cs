using System;

namespace Chapter_10___State_Pattern
{
    public class SoldState : GumballState
    {
        //Instance of Machine
        private GumballMachine Machine;

        public SoldState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Not Accpeting Quarters!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You already turned the Crank, No Quarter to Eject!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Quarter in Transaction, blocking Turn Crank Action!");
        }

        public void Dispense()
        {
            
            if (Machine.GetCount() > 0)
            {
                Console.WriteLine("Dispensing Gumball...");
                Machine.SetGumballState(Machine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, we're out of Gumballs!");
                Machine.SetGumballState(Machine.GetSoldOutState());
            }
        }

        public void Refill(int gumballs)
        {
            throw new NotImplementedException();
        }
    }
}
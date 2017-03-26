using System;

namespace Chapter_10___State_Pattern
{
    public class HasQuarterState : GumballState
    {
        //Instance of Machine
        private GumballMachine Machine;
        static Random random = new Random();
        

        public HasQuarterState(GumballMachine machine)
        {
            Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter Already Inserted!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting Quarter!");
            Machine.SetGumballState(Machine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning Crank!");
            int winner = random.Next(0, 10);
            if ((winner == 0) && (Machine.GetCount() > 1))
            {
                Machine.SetGumballState(Machine.GetWinnerState());
            }
            else
            {
                Machine.SetGumballState(Machine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("Can Only Dispense from SOLD State.");
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
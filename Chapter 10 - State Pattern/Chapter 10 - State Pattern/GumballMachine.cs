using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10___State_Pattern
{
    public class GumballMachine : GumballState
    {
        //The 4 States + Change Request Winner
        private static GumballState HAS_QUARTER;
        private static GumballState NO_QUARTER;
        private static GumballState SOLD;
        private static GumballState SOLD_OUT;
        private static GumballState WINNER;

        //Default State & Counter
        private GumballState State = SOLD_OUT;
        private int count = 0;

        public GumballMachine(int count)
        {
            //Initializing States
            HAS_QUARTER = new HasQuarterState(this);
            NO_QUARTER = new NoQuarterState(this);
            SOLD = new SoldState(this);
            SOLD_OUT = new SoldOutState(this);
            WINNER = new WinnerState(this);

            //State when Created.
            this.count = count;
            if (count > 0)
            {
                State = NO_QUARTER;
            }
        }

        //Set State
        public void SetGumballState(GumballState state)
        {
            State = state;
        }
        //Get States
        public GumballState GetSoldOutState()
        {
            return SOLD_OUT;
        }
        public GumballState GetNoQuarterState()
        {
            return NO_QUARTER;
        }
        public GumballState GetSoldState()
        {
            return SOLD;
        }
        public GumballState GetHasQuarterState()
        {
            return HAS_QUARTER;
        }

        public GumballState GetWinnerState()
        {
            return WINNER;
        }
        public int GetCount()
        {
            return count;
        }

        public void SetCount(int gumballcount)
        {
            count = gumballcount;
        }

        //Actions
        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
        }

        public void Dispense()
        {
            State.Dispense();
        }
        //New Refill Method
        public void Refill(int gumballs)
        {
            //Only Implmented in SoltOutState
            State.Refill(gumballs);
        }
    }
}

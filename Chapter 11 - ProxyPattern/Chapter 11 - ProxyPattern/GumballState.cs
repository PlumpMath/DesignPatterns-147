using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11___ProxyPattern
{
    public interface GumballState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill(int gumballs);
    }
    public class HasQuarterState : GumballState
    {
        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void Refill(int gumballs)
        {
            throw new NotImplementedException();
        }
    }
}

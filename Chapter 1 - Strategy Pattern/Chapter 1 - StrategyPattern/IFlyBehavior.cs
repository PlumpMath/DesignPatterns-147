using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1___StrategyPattern
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying Action Envoked.");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No Flying Action Envoked.");
        }
    }

    //New Functionality Management was looking for!
    public class RocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Rocket Powered Action Envoked.");
        }
    }
}

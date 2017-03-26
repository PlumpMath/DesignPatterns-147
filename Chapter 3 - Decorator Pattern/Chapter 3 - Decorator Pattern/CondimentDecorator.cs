using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3___Decorator_Pattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }

    public class Whip : CondimentDecorator
    {
        Beverage Beverage;

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }
        public override double GetPrice()
        {
            return Beverage.GetPrice() + .15;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
        public override double GetPrice()
        {
            return Beverage.GetPrice() + .20;
        }
    }

    public class Milk : CondimentDecorator
    {
        Beverage Beverage;

        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }
        public override double GetPrice()
        {
            return Beverage.GetPrice() + .10;
        }
    }
}

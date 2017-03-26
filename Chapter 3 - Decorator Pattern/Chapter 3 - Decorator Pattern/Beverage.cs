using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3___Decorator_Pattern
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }
        public abstract double GetPrice();
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        public override double GetPrice()
        {
            return .99;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double GetPrice()
        {
            return 1.20;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }
        public override double GetPrice()
        {
            return .89;
        }
    }
}

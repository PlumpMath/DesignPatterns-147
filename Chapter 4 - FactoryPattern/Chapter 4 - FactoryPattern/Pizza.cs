using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___FactoryPattern
{
    public abstract class Pizza
    {
        protected string Name, Dough, Sauce;

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking @ 250c for 25 Minutes.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pizza into Slices.");
        }

        public void Box()
        {
            Console.WriteLine("Placing Pizza in Official Pizza Store Box. \n");
        }
    }

    //Types of Pizza
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
        }
    }

    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
        }
    }

    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
        }
    }
}

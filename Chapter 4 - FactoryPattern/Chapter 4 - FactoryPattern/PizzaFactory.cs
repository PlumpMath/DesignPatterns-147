using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___FactoryPattern
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza();
            }
            else
            {
                Console.WriteLine("Could not find Pizza Type.");
                pizza = null;
            }
            return pizza;
        }
    }
}

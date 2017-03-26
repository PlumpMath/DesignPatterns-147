using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 4 - Factory Pattern:");

            //Create Factory
            PizzaFactory factory = new PizzaFactory();
            //Create Store, and pass Factory.
            PizzaStore store = new PizzaStore(factory);

            store.OrderPizza("Cheese");
            store.OrderPizza("Pepperoni");
            store.OrderPizza("Veggie");


            Console.ReadKey();
        }
    }
}

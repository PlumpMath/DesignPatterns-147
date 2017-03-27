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
            Console.WriteLine("Creating Factory:");
            PizzaFactory factory = new PizzaFactory();

            //Create Store, and pass Factory.
            Console.WriteLine("Creating Store & Passing Factory Object:");
            PizzaStore store = new PizzaStore(factory);

            Console.WriteLine("One Cheese Pizza Coming up! \n");
            store.OrderPizza("Cheese");

            Console.WriteLine("One Pepperoni Pizza Coming up! \n");
            store.OrderPizza("Pepperoni");

            Console.WriteLine("One Veggie Pizza Coming up!");
            store.OrderPizza("Veggie");


            Console.ReadKey();
        }
    }
}

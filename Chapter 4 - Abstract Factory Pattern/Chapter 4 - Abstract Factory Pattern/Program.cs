using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4___Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 4 - Abstract Factory Pattern:");

            Console.WriteLine("Brooklynn Store Grand Opening:");
            Order(new NewYorkPizzaStore());

            Console.WriteLine("Sunset Blvrd Store Grand Opening:");
            Order(new CaliforniaPizzaStore());

            Console.WriteLine("Chicago College Store Grand Opening:");
            Order(new ChicagoPizzaStore());

            Console.ReadKey();
        }
        public static void Order(PizzaStore store)
        {
            store.OrderPizza("cheese");
            store.OrderPizza("pepperoni");
            store.OrderPizza("veggie");
        }
    }
}

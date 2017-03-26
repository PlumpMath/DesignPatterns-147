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

            Console.WriteLine("-------Brooklynn Store Grand Opening-------");
            PizzaStore brooklynnPizzaStore = new NewYorkPizzaStore();
            brooklynnPizzaStore.OrderPizza("cheese");
            brooklynnPizzaStore.OrderPizza("pepperoni");
            brooklynnPizzaStore.OrderPizza("veggie");


            Console.WriteLine("-------Sunset Blvrd Store Grand Opening-------");
            PizzaStore sunsetPizzaStore = new CaliforniaPizzaStore();
            sunsetPizzaStore.OrderPizza("cheese");
            sunsetPizzaStore.OrderPizza("pepperoni");
            sunsetPizzaStore.OrderPizza("veggie");

            //The
            Console.WriteLine("-------Chicago College Store Grand Opening-------");
            PizzaStore bostonPizzaStore = new ChicagoPizzaStore();
            bostonPizzaStore.OrderPizza("cheese");
            bostonPizzaStore.OrderPizza("pepperoni");
            bostonPizzaStore.OrderPizza("veggie");

            Console.ReadKey();
        }
    }
}

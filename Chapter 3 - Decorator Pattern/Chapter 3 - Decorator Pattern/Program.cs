
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3___Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 3 - Decorator Pattern:");

            Console.WriteLine("Creating Our 3 Beverages:");
            Beverage firstBeverage = new DarkRoast();
            Beverage secondBeverage = new Espresso();
            Beverage thirdBeverage = new HouseBlend();


            Console.WriteLine("Decorating Beverages to Add Condiments:");
            secondBeverage = new Whip(secondBeverage);
            thirdBeverage = new Milk(thirdBeverage);
            thirdBeverage = new Mocha(thirdBeverage);

            Console.WriteLine("Sending Beverages to Print Method:");
            PrintBeverage(firstBeverage); //Undecorated Object
            PrintBeverage(secondBeverage);//Single Decorated Object
            PrintBeverage(thirdBeverage);//Double Decorated object

            Console.ReadKey();
        }

        public static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine("Beverage: {0} - Price: {1}" , beverage.GetDescription(), beverage.GetPrice());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 8 - Template Pattern:");

            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();

            PrepareBeverages(tea);
            PrepareBeverages(coffee);

            Console.ReadKey();
        }

        public static void PrepareBeverages(CaffeineBeverage beverage)
        {
            Console.WriteLine("-------One {0} Beverage Coming Up---------" , beverage.GetType().Name);
            beverage.Boil();
            beverage.Brew();
            beverage.PourInCup();
            beverage.AddCondiments();
        }
    }
}

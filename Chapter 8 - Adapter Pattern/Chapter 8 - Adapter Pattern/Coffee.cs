using System;

namespace Chapter_8___Adapter_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing Coffee Grinds.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar & Milk.");
        }
    }
}

using System;

namespace Chapter_8___Adapter_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping Tea Bag.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }
    }
}
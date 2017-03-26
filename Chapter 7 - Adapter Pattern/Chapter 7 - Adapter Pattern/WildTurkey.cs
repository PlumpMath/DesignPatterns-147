using System;

namespace Chapter_7___Adapter_Pattern
{
    public class WildTurkey : TurkeyAdapter
    {
        public void Display()
        {
            Console.WriteLine("I am a Wild Turkey.");
        }
    }
}

using System;

namespace Chapter_7___Adapter_Pattern
{
    public class TurkeyAdapter : IDuck, ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Mutant Duck-Turkey Fly Action!");
        }
        public void Quack()
        {
            Console.WriteLine("Mutant Duck-Turkey Quack!");
        }
        public void Gobble()
        {
            Quack();
        }
        public void Glide()
        {
            Fly();
        }
    }
}

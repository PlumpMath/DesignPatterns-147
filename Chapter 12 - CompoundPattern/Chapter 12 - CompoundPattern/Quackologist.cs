using System;

namespace Chapter_12___CompoundPattern
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: {0} Just Quack!" , duck.GetType().Name);
        }
    }
}
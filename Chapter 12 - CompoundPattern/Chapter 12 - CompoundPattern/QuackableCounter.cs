using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    //Step 8. Adding in Duck Counter with the Decorator Pattern.
    public class QuackableCounter : IQuackable
    {
        private IQuackable duck;
        public static int numberOfQuacks;

        public QuackableCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }

        public int GetQuacks()
        {
            return numberOfQuacks;
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
           duck.NotifyObservers();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }

    public class MallardDuck : IQuackable
    {
        private Observable _observable;

        public MallardDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Quack!");
            //Letting the Observers know we Quacked
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class RedheadDuck : IQuackable
    {
        private Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Redhead Quack!");
            //Letting the Observers know we Quacked
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class DuckCall : IQuackable
    {
        private Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Duck Call Kwak!");
            //Letting the Observers know we Quacked
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }

    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Rubber Duck Squeak!");
            //Letting the Observers know we Quacked
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}

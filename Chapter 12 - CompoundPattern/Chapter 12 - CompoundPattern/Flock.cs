using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    //Step 12. Implmenting a Composite Pattern to manage our collection of Ducks.
    public class Flock : IQuackable
    {
        ArrayList ducks = new ArrayList();

        public void Add(IQuackable quacker)
        {
            Console.WriteLine("Quacker {0} Added to Flock." , quacker.GetType().Name);
            ducks.Add(quacker);
        }

        public void Quack()
        {   
            DuckIterator iterator = new DuckIterator(ducks);
            while (iterator.HasNext())
            {
                IQuackable quacker = (IQuackable) iterator.Next();
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            DuckIterator iterator = new DuckIterator(ducks);
            while (iterator.HasNext())
            {
                IQuackable duck = (IQuackable)iterator.Next();
                duck.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            //Flock Delegates this to the individual items, should be oke!
            throw new NotImplementedException();
        }
    }

    //Creating the Iterator for Flock to use.
    public class DuckIterator
    {
        ArrayList items = new ArrayList();
        private int _position;
        public DuckIterator(ArrayList incoming)
        {
            items = incoming;
        }
        public Object Next()
        {
            Object quacker = (Object)items[_position];
            _position++;
            return quacker;
        }

        public Boolean HasNext()
        {
            if (items.Count > _position)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    //Step 14. Okay they liked the Composite, we can now perform the same actions on Collections of Objects.
    //However, we can we maybe get the opposite? Track INDIVIDUAL Quackers in Real time. Maybe some sort of Observer?

    //To be Implemented by Ducks that want to be Observed.
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }

    //Need to Create Observer they have in Java

    //Creating the Quackologist, we might want this data!

    public class Observable : IQuackObservable
    {
        ArrayList observers = new ArrayList();
        private IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            DuckIterator iterator = new DuckIterator(observers);
            while (iterator.HasNext())
            {
                IObserver observer = (IObserver) iterator.Next();
                observer.Update(duck);
            }
        }
    }
}

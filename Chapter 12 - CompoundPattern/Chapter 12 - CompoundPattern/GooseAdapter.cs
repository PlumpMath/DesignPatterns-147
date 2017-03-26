using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___CompoundPattern
{
    //Step 5. Adding Waterfowl into the mix, using the Adapter Pattern
    public class GooseAdapter : IQuackable
    {
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }
        public void Quack()
        {
            //Perform Honk when Quack is Method is Used.
            goose.Honk();
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

    public class Goose
    {
        public void Honk()
        {
            Console.WriteLine("Honk!");
        }
    }
}

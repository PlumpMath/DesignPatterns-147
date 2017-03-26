using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___Adapter_Pattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            Boil();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void Boil()
        {
            Console.WriteLine("Boiling Water");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup.");
        }

        public abstract void AddCondiments();
    }
}

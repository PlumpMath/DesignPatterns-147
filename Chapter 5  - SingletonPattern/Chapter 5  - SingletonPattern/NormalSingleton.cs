using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5____SingletonPattern
{
    /*Normal Singleton as suggested in Design Patterns, but implementing some CLR features like properties.
        Advantages of this Design:
        -Have Access to Instance Property, and included functionality eg instantiating a subclass
        -The use of "Lazy instantiation" defers object creation until absolutely neccessary.

        Disadvantage:
        This design is NOT Thread Safe.
    */
    public class NormalSingleton
    {
        private static NormalSingleton _instance;

        public static NormalSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NormalSingleton();
                }
                return _instance;
            }
        }

        public void PerformAction()
        {
            Console.WriteLine("Normal Singleton - Performing Memrory Intensive Operation.");
        }
    }
}

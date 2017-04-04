using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5____SingletonPattern
{
    /*Static Initialization Singleton:
     * In this strategy, we create the Instance of the Class whenever any member is referenced, but allow the CLR take care of variable initialization.
     * We still provide global access to the Class, but defer management to the CLR.
     */
    public sealed class SingletonTwo
    {
        private static readonly SingletonTwo instance = new SingletonTwo();

        //Private Constructor means only the Class itself can create an instance.
        private SingletonTwo()
        {
        }

        public static SingletonTwo Instance
        {
            get
            {
                return instance;
            }
        }
        public void PerformAction()
        {
            Console.WriteLine("Static Initialization Singleton - Performing Memrory Intensive Operation.");
        }
    }
}

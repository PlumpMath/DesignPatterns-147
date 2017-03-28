using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5____SingletonPattern
{
    //Thread Safe Singleton
    public sealed class ChocolateBoilerSingleton
    {
        protected bool empty, boiled;

        //Informing CLR these objects are volatile.(Don't Cache the value)
        private static volatile ChocolateBoilerSingleton uniqueInstance;
        private static object syncRoot = new Object();

        private ChocolateBoilerSingleton()
        {
            boiled = false;
            empty = true;
        }

        public static ChocolateBoilerSingleton Instance
        {
            get
            {
                //Check UnqiueInstance
                if (uniqueInstance == null)
                {
                    //Lock the Check Again, to avoid Race Conditions.
                    lock (syncRoot)
                    {
                        //Final Check
                        if (uniqueInstance == null)
                        {
                            //Assign Instance of Class
                            uniqueInstance = new ChocolateBoilerSingleton();
                        }
                    }
                }
                return uniqueInstance;
            }
        }
        //Normal Boiler Methods
        public void Fill()
        {
            if (empty == true)
            {
                Console.WriteLine("Filling Tank");
                empty = false;
            }
        }
        public void Boil()
        {
            if (empty == false && boiled == false)
            {
                Console.WriteLine("Boiling Tank");
                boiled = true;
            }
        }
        public void Drain()
        {
            if (boiled == true && empty == false)
            {
                Console.WriteLine("Draining Tank");
                empty = true;
                boiled = false;
            }
        }
    }
}

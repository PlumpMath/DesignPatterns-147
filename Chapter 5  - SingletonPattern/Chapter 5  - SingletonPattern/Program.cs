using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5____SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 - Singleton Pattern:");

            //Simple Singleton
            NormalSingleton.Instance.PerformAction();

            //Static Initialization
            SingletonTwo.Instance.PerformAction();

            //Thread Safe
            Console.WriteLine("Thread Safe Singleton - Creating Thread Safe Singleton.");
            //Assignment Not Allowed:
            //ChocolateBoilerSingleton boiler = new ChocolateBoilerSingleton();

            //Interacting with our Singleton
            ChocolateBoilerSingleton.Instance.Fill();
            ChocolateBoilerSingleton.Instance.Boil();
            ChocolateBoilerSingleton.Instance.Drain();

            
            Console.ReadKey();
        }
    }
}

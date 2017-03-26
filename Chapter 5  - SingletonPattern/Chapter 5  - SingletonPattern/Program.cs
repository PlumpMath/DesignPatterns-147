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

            //Interacting with our Singleton
            ChocolateBoilerSingleton.Instance.Fill();
            ChocolateBoilerSingleton.Instance.Boil();
            ChocolateBoilerSingleton.Instance.Drain();


            Console.ReadKey();
        }
    }
}

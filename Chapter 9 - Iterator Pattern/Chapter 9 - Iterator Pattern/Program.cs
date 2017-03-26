using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 9 - Iterator Pattern:");

            //Create Menu
            DinerMenu dinerMenu = new DinerMenu();
            PancakeMenu pancakeMenu = new PancakeMenu();

            ArrayList AllMenus = new ArrayList();
            AllMenus.Add(dinerMenu);
            AllMenus.Add(pancakeMenu);

            //Pass Menu to Watiress
            Waitress watiress = new Waitress(AllMenus);

            watiress.PrintMenu();


            Console.ReadKey();
        }
    }
}

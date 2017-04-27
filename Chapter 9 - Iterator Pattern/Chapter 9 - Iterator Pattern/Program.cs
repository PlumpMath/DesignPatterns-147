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
            Console.WriteLine("Launcher - Creating Menu Objects:");
            DinerMenu dinerMenu = new DinerMenu();
            PancakeMenu pancakeMenu = new PancakeMenu();

            Console.WriteLine("Launcher - Creating AllMenu Container, adding DinerMenu & PancakeMenu:");
            ArrayList AllMenus = new ArrayList();
            AllMenus.Add(dinerMenu);
            AllMenus.Add(pancakeMenu);

            //Pass Menu to Watiress
            Console.WriteLine("Passing All Menu to Waitress");
            Waitress watiress = new Waitress(AllMenus);

            Console.WriteLine("Waitress - Printing Menus Items:");
            watiress.PrintMenu();


            Console.ReadKey();
        }
    }
}

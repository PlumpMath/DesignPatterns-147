using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent combinedMenu = new Menu("Combined Menu", "All various Menus.");
            MenuComponent breakfast = new Menu("Breakfast Menu", "Breakfast Menu Items");
            MenuComponent lunch = new Menu("Lunch Menu","Lunch Menu Items");
            MenuComponent subMenu = new Menu("Sub Menu", "Sub Menu Items.");


            combinedMenu.Add(breakfast);
            lunch.Add(subMenu);
            combinedMenu.Add(lunch);

            breakfast.Add(new MenuItem("Pastry", "Some Pastry Description", true, 2.49));

            Waitress waitress = new Waitress(combinedMenu);
            waitress.Print();

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections;

namespace Chapter_9___Iterator_Pattern
{
    public class Waitress
    {
        ArrayList Menus = new ArrayList();

        public Waitress(ArrayList menus)
        {
            Menus = menus;
        }

        public void PrintMenu()
        {
            Iterator menuIterator = new MenuIterator(Menus);

            while (menuIterator.HasNext())
            {
                IMenu menu = (IMenu)menuIterator.Next();
                Print(menu.CreateIterator());
            }
        }

        public void Print(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem item = (MenuItem) iterator.Next();
                Console.WriteLine("     {0} - {1} - V: {2} - ${3}", item.GetName(), item.GetDescription(), item.IsVegeterian(), item.GetPrice());
            }
        }
    }
}

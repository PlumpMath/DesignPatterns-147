using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
   //Menu Composite Class
    public class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        private string Name, Description;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent component)
        {
            Console.WriteLine("Component Added Successfully:");
            menuComponents.Add(component);
        }
        public override void Remove(MenuComponent component)
        {
            menuComponents.Add(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent) menuComponents[i];
        }

        public override string GetName()
        {
            return Name;
        }
        public override string GetDescription()
        {
            return Description;
        }

        public override void Print()
        {
            Console.WriteLine("----------------MENU:---------------------");
            Console.WriteLine("{0}, {1}" , GetName(), GetDescription());
            Console.WriteLine("-----------------------------------------");

            //Print Menus & SubMenus
            MenuIterator menuIterator = new MenuIterator(menuComponents);
            while (menuIterator.HasNext())
            {
                MenuComponent component = (MenuComponent) menuIterator.Next();
                Console.WriteLine("Component Retrived: {0}" , component.GetType().Name);
                component.Print(); //Printing Individual Component(Also through this class.)
            }
        }
        //Adding Iterator
        public override Iterator CreateIterator()
        {
            //Using our Specific Menu Iterator
            return new CompositeIterator(new MenuIterator(menuComponents));
        }
    }
}

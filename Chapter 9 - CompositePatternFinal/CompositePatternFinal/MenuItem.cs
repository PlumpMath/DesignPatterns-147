using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    public class MenuItem : MenuComponent
    {
        private string Name, Description;
        private Boolean Vegeterian;
        private double Price;

        public MenuItem(string name, string description, Boolean vegeterian, double price)
        {
            Name = name;
            Description = description;
            Vegeterian = vegeterian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsVegeterian()
        {
            return Vegeterian;
        }
        //Menu Item Specific Print Method
        public override void Print()
        {
            Console.Write("    Item: {0}", GetName());
            if (IsVegeterian())
            {
                Console.Write(" (V) ");
            }
            Console.WriteLine("{0}, {1}", GetDescription(), GetPrice());
        }

        public override Iterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}

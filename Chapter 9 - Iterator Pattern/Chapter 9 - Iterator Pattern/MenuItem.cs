using System;

namespace Chapter_9___Iterator_Pattern
{
    public class MenuItem
    {
        private string Name, Description;
        private Boolean Vegeterian;
        private double Price;

        public MenuItem(string name, string description, Boolean vegeterian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegeterian = vegeterian;
            this.Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public double GetPrice()
        {
            return Price;
        }

        public Boolean IsVegeterian()
        {
            return Vegeterian;
        }
    }
}
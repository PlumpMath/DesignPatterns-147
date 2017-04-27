﻿using System;
using System.Collections;

namespace Chapter_9___Iterator_Pattern
{
    public interface IMenu
    {
        Iterator CreateIterator();
    }

    //ArrayList Menu
    public class DinerMenu : IMenu
    {
        ArrayList menuArrayList = new ArrayList();

        public DinerMenu()
        {
            AddItems("Steak & Chips", "T-Bone Steak with Hand cut Fries", false, 18.99);
            AddItems("CheeseBurger Meal", "Cheese Burger & Chips Combo", false, 12);
            AddItems("Lasagna", "Vegeterian Lassagna", true, 7.99);
            AddItems("Seafood Delight", "Seafood Chowder, with a choice of sides", false, 16);
        }
        public void AddItems(string name, string description, Boolean vegeterian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegeterian, price);
            menuArrayList.Add(item);
        }
        public Iterator CreateIterator()
        {
            DinerMenuIterator dinerIterator = new DinerMenuIterator(menuArrayList);
            return dinerIterator;
        }
    }

    //Array Menu
    public class PancakeMenu : IMenu
    {
        private static readonly int MAX_ITEMS = 4;
        private int count = 0;
        private MenuItem[] menuItems;

        public PancakeMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Pankcake","Pankcake & Nutella", true, 2.75);
            AddItem("Waffles Haus", "Waffle Plate with a la carte menu", false, 4.50);
            AddItem("Desert Pancake", "Pankcake with Ice Cream & Fresh Fruits", false, 4.50);
        }

        public void AddItem(string name, string description, Boolean vegeterian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegeterian, price);
            if (MAX_ITEMS < count)
            {
                Console.WriteLine("Sorry Menu is full!");
            }
            else
            {
                menuItems[count] = menuItem;
                count++;
            }
        }

        public Iterator CreateIterator()
        {
            PancakeIterator dinerIterator = new PancakeIterator(menuItems);
            return dinerIterator;
        }
    }
}

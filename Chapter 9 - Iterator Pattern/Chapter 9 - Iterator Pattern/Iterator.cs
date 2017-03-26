using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9___Iterator_Pattern
{
    public interface Iterator
    {
        Object Next();
        Boolean HasNext();
    }

    public class DinerMenuIterator : Iterator
    {
        ArrayList _items = new ArrayList();
        private int position;

        public DinerMenuIterator(ArrayList items)
        {
            _items = items;
        }

        public Object Next()
        {
            MenuItem item = (MenuItem) _items[position];
            position++;
            return item;
        }

        public Boolean HasNext()
        {
            if (position < _items.Count && _items[position] != null)
            {
                //If Item[position] is valid, return true.
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class PancakeIterator : Iterator
    {
        private MenuItem[] Items;
        private int position;

        public PancakeIterator(MenuItem[] items)
        {
            Items = items;
        }

        public Object Next()
        {
            MenuItem item = (MenuItem)Items[position];
            position++;
            return item;
        }

        public Boolean HasNext()
        {
            if (position >= Items.Length || Items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public class MenuIterator : Iterator
    {
        ArrayList _menus = new ArrayList();
        private int position;

        public MenuIterator(ArrayList menus)
        {
            _menus = menus;
        }

        public Object Next()
        {
            IMenu item = (IMenu)_menus[position];
            position++;
            return item;
        }

        public Boolean HasNext()
        {
            if (position < _menus.Count && _menus[position] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

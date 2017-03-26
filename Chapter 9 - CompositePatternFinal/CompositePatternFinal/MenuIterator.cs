using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
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
            MenuComponent item = (MenuComponent)_menus[position];
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

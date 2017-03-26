using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    public class Waitress
    {
        private MenuComponent AllMenus;

        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void Print()
        {
            AllMenus.Print();
        }
    }
}

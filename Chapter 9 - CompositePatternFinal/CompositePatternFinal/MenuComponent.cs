using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    public abstract class MenuComponent
    {
        //Composite Methods - Menu Methods
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }

        //Shared Methods
        public virtual void Print()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual Iterator CreateIterator()
        {
            throw new NotSupportedException("Opertion NOT supported");
        }
        //Menu Item Methods
        public virtual string GetName()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual string GetDescription()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual Boolean IsVegeterian()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
        public virtual double GetPrice()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
    }
}

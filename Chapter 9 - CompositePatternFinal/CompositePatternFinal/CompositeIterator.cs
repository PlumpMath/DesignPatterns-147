using System;
using System.Collections;

namespace CompositePatternFinal
{
    public class CompositeIterator : Iterator
    {
        Stack stack = new Stack();
        public CompositeIterator(Iterator iterator)
        {
            stack.Push(iterator);
        }
        public Object Next()
        {
            if (HasNext())
            {
                Iterator iterator = (Iterator)stack.Peek();
                MenuComponent component = (MenuComponent)iterator.Next();

                if (component.GetType() == typeof(Menu))
                {
                    stack.Push(component.CreateIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }
        public Boolean HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                Iterator iterator = (Iterator)stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }
        public void Remove()
        {
            throw new NotSupportedException("Opertion NOT Supported.");
        }
    }
}

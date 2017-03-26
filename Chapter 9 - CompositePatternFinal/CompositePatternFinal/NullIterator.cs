using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    public class NullIterator : Iterator
    {
        public Object Next()
        {
            return null;
        }

        public Boolean HasNext()
        {
            return false;
        }

        public void Remove()
        {
            throw new NotSupportedException("Operation NOT Supported.");
        }
    }
}

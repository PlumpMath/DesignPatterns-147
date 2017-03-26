using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFinal
{
    public interface Iterator
    {
        Object Next();
        Boolean HasNext();
    }
}

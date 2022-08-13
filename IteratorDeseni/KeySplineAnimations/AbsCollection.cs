using System;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public interface AbsCollection
    {
        AbsIterator CreateIterator();
    }
}

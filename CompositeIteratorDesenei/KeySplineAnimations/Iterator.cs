using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public class Iterator : IEnumerator<YazıOzellik>
    {
        public void Dispose() { }

        public bool MoveNext() => false;

        public void Reset() { }

        public YazıOzellik Current => null;

        object IEnumerator.Current => Current;
    }
}

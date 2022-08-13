using System;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public class Collection : AbsCollection
    {
        private List<YazıOzellik> listyazıozellik = new List<YazıOzellik>();

        public AbsIterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listyazıozellik.Count; }
        }

        public void AddYazıOzellik(YazıOzellik yazıOzellik)
        {
            listyazıozellik.Add(yazıOzellik);
        }

        public YazıOzellik GetYazıOzellik(int indexposition)
        {
            return listyazıozellik[indexposition];
        }
    }
}

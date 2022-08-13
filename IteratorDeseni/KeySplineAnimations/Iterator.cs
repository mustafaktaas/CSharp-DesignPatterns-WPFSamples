using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace KeySplineAnimations
{
    public class Iterator : AbsIterator
    {

        private Collection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }
        public bool isComplete
        {
            get { return current >= collection.Count; }
        }

        public YazıOzellik First()
        {
            current = 0;
            return collection.GetYazıOzellik(current);
        }

        public YazıOzellik Next()
        {
            current += step;
            if (!isComplete)
            {
                return collection.GetYazıOzellik(current);
            }
            else
            {
                return null;
            }
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}

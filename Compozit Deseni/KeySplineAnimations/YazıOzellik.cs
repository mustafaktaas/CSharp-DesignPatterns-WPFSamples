using System;
using System.Collections.Generic;
using System.Text;

namespace KeySplineAnimations
{
    public abstract class YazıOzellik 
    {
     
        public virtual string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool IsUstDuzey
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Add(YazıOzellik yazıOzellik)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(YazıOzellik yazıOzellik)
        {
            throw new NotImplementedException();
        }
        public virtual YazıOzellik GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}

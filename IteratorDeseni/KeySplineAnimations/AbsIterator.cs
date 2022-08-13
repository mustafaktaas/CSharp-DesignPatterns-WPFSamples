using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace KeySplineAnimations
{
    public interface AbsIterator
    {
        YazıOzellik First();

        YazıOzellik Next();

        void Remove();

        bool isComplete { get; }
    }
}

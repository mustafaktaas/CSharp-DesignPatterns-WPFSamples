using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace KeySplineAnimations
{
    public class Yazı : YazıOzellik
    {
       
        private readonly List<YazıOzellik> _yazıOzellik = new List<YazıOzellik>();

        public Yazı(string name)
        {
            Name = name;
        }

        public override string Name { get; }

        public override void Add(YazıOzellik yazıOzellik)
        {
            _yazıOzellik.Add(yazıOzellik);
        }

        public override void Remove(YazıOzellik yazıOzellik)
        {
            _yazıOzellik.Remove(yazıOzellik);
        }

        public override YazıOzellik GetChild(int i)
        {
            return _yazıOzellik[i];
        }

        public override void Print()
        {

            MessageBox.Show(Name);

            var iterator = _yazıOzellik.GetEnumerator();
            while (iterator.MoveNext())
            {
                YazıOzellik yazıOzellik = iterator.Current;
                yazıOzellik?.Print();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace KeySplineAnimations
{
    public class CompositeIterator : IEnumerator<YazıOzellik>
    {
        private readonly IEnumerator<YazıOzellik> _iterator;
        private readonly Stack<IEnumerator<YazıOzellik>> _stack = new Stack<IEnumerator<YazıOzellik>>();
        private YazıOzellik _current;

        public CompositeIterator(IEnumerator<YazıOzellik> iterator)
        {
            _iterator = iterator;
            _stack.Push(iterator);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (!_stack.Any())
            {
                _current = null;
                return false;
            }

            var iterator = _stack.Peek();
            if (!iterator.MoveNext())
            {
                _stack.Pop();
                return MoveNext();
            }

            _current = iterator.Current;

            if (_current is Yazı)
            {
                _stack.Push(_current.CreateIterator());
            }

            return true;
        }

        public void Reset()
        {
            _current = null;
            _stack.Clear();
            _stack.Push(_iterator);
        }

        public YazıOzellik Current => _current;

        object IEnumerator.Current => Current;
    }
}

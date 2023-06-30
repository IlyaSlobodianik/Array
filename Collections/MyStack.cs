using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class MyStack<T>
    {
        private int _length;
        private T _top;
        private T[] _stack;

        public int Length => _length;
        public T Top => _top;
        public MyStack()
        {
            _length = 0;
            _stack = new T[_length];
        }
    }
}

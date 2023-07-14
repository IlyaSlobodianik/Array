using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class MyStack<T> : IEnumerable<T>
    {
        private MyArray<T> _array;

        public int Count => _array.Length;
        public T Top => _array[Count - 1];
        public MyStack()
        {
            _array = new();
        }
        public void Push(T value) => _array.Add(value);
        public T Pop() => _array.Pop();
        public bool Contains(T value) => _array.Contains(value);
        public T Peek() => _array[Count - 1];
        public void Clear() => _array.Clear();
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>) _array).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}

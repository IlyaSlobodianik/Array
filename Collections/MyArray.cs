namespace Collections
{
    public class MyArray<T>
    {
        private T[] _array;
        private int _length;

        public int Length => _length;
        public MyArray()
        {
            _length = 0;
            _array = new T[0];
        }
        public void Add(T value)
        {
            _length++;
            T[] tmp = new T[_length];
            for (int i = 0; i < _length - 1; i++)
            {
                tmp[i] = _array[i];
            }
            tmp[_length - 1] = value;
            _array = tmp;
        }
        public void Print()
        {
            foreach (var value in _array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            _length = 0;
            _array = new T[0];
        }
        public T Pop()
        {
            _length--;
            T[] tmp = new T[_length];
            for (int i = 0; i < _length; i++)
            {
                tmp[i] = _array[i];
            }
            T removed = _array[_length];
            _array = tmp;
            return removed;

        }
        public bool Insert(int index, T value)
        {
            if (index < 0 || index >= Length) return false;
            _length++;
            T[] tmp = new T[_length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }
            tmp[index] = value;
            for (int i = index; i < _array.Length; i++)
            {
                tmp[i + 1] = _array[i];
            }
            _array = tmp;
            return true;
        }
        public bool Contains(T value)
        {
            foreach (var i in _array)
            {
                if (i.Equals(value))
                    return true;
            }
            return false;
        }
        public int IndexOf(T value)
        {
            for (int i = 0; i < _length; i++)
            {
                if (value.Equals(_array[i]))
                    return i;
            }
            return -1;
        }
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Length) return false;
            _length--;
            T[] tmp = new T[_length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }
            for (int i = index + 1; i < _array.Length; i++)
            {
                tmp[i - 1] = _array[i];
            }
            _array = tmp;
            return true;
        }
        public bool Remove(T value) => RemoveAt(IndexOf(value));
    }
}
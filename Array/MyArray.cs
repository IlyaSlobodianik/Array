using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace ArrayTask
{
    internal class MyArray
    {
        private int[] _array;
        private int _length;

        public int Length => _length;
        public MyArray()
        {
            _length = 0;
            _array = new int[0];
        }
        public void Add(int value)
        {
            _length++;
            int[] tmp = new int[_length];
            for (int i = 0; i < _length - 1; i++)
            {
                tmp[i] = _array[i];
            }
            tmp[_length - 1] = value;
            _array = tmp;
        }
        public void Print()
        {
            foreach (int value in _array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public void Clear()
        {
            _length = 0;
            _array = new int[0];
        }
        public int Pop()
        {
            _length--;
            int[] tmp = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                tmp[i] = _array[i];
            }
            int removed = _array[_length];
            _array = tmp;
            return removed;

        }
        public bool Insert(int index, int value)
        {
            if (index < 0 || index >= Length) return false;
            _length++;
            int[] tmp = new int[_length];
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
        public bool Contains(int value)
        {
            foreach(int i in _array)
            {
                if(i == value) //Здесь отвалится 
                    return true;
            }
            return false;
        }
        public int IndexOf(int value)
        {
            for(int i = 0; i < _length; i++)
            {
                if(value == _array[i]) //Здесь отвалится
                    return i;
            }
            return -1;
        }
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Length) return false;
            _length--;
            int[] tmp = new int[_length];
            for (int i = 0; i < index; i++)
            {
                tmp[i] = _array[i];
            }
            for(int i = index + 1; i < _array.Length; i++)
            {
                tmp[i - 1] = _array[i];
            }
            _array = tmp;
            return true;
        }
        public bool Remove(int value)
        {
            if(Contains(value))
            {
               RemoveAt(IndexOf(value));
               return true;
            }
            else return false;
        }
    }
}

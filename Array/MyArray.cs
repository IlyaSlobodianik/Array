﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

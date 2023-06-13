using System;
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
        public MyArray()
        {
            _length = 0;
            _array = new int[0];
        }
        public void Add(int value)
        {
            _length++;
            int[] tmp = new int[_length];
            for(int i = 0; i < _length-1; i++)
            {
                tmp[i] = _array[i];
            }
            tmp[_length-1] = value;
            _array = tmp;
        }
        public void Print()
        {
            foreach(int value in _array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

    }
}

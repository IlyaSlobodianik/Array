using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class MyDictionary<TKey, TValue> :IEnumerable<KeyValuePair<TKey, TValue>>
    {
        #region Private variables
        private List<TKey> _keys;
        private List<TValue> _values;
        #endregion
        #region Public properties
        public int Count => _keys.Count;
        #endregion
        #region Indexer
        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);
                if (index >= 0)
                {
                    return _values[index];
                }
                throw new KeyNotFoundException();
            }
            set 
            {
                int index = _keys.IndexOf(key);
                if (index >= 0)
                {
                    _values[index] = value;
                }
                else
                    Add(key, value);
            }
        }
        #endregion
        #region Constructor
        public MyDictionary() 
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }
        #endregion
        #region Methods
        public void Add(TKey key, TValue value) 
        {
            if(_keys.Contains(key)) 
            {
                _values[_keys.IndexOf(key)] = value;
            }
            else
            {
                _keys.Add(key);
                _values.Add(value);
            }
        }
        public void Clear() 
        {
            _keys.Clear();
            _values.Clear();
        }
        
        public bool Remove(TKey key) 
        {
            int index = _keys.IndexOf(key);
            if(index >= 0) 
            {
                _keys.RemoveAt(index);
                _values.RemoveAt(index);
                return true;
            }
            return false;
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            int index = _keys.IndexOf(key);
            if (index >= 0)
            {
                value = _values[index];
                return true;
            }
            value = default(TValue);
            return false;
        }
        public bool ContainsKey(TKey key) => _keys.Contains(key);
        #endregion
        #region IEnumerable implementations
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for(int i = 0; i < _keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

    }
}

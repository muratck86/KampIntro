using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyDict
{
    class MyDict<K, V> : IDictionary
    {
        private class Entry<K, V>
        {
            public Entry(K k, V v)
            {
                Key = k;
                Value = v;
            }
            public K Key { get; }
            public V Value { get; set; }
        }

        private int _CAPACITY = 10;
        private int _size;
        private Entry<K, V>[] dict;

        public MyDict()
        {
            dict = new Entry<K, V>[_CAPACITY];
        }

        private int FindKey(object key)
        {
            K k = ((K)key);
            for (int i = 0; i <_size; i++)
            {
                if (dict[i].Key.Equals(k))
                {
                    return i;
                }
            }
            return -1;
        }

        public object this[object key] {
            get {
                int index = FindKey(key);
                return index >= 0 ? dict[index].Value : throw new KeyNotFoundException();
            }
            set {
                int k = (int)key;
                dict[k].Value = (V)value;
            } 
        }

        public bool IsFixedSize => false;

        public bool IsReadOnly => throw new NotImplementedException();

        public ICollection Keys => throw new NotImplementedException();

        public ICollection Values => throw new NotImplementedException();

        public int Count => _size;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(object key, object value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            if(FindKey(key) == -1)
            {
                K k = (K)key;
                V v = (V)value;
                if (_size >= dict.Length)
                {
                    Entry<K, V>[] temp = new Entry<K, V>[dict.Length * 2];
                    for (int i = 0; i < dict.Length; i++)
                    {
                        temp[i] = dict[i];
                    }
                    dict = temp;
                }
                dict[_size++] = new Entry<K, V>(k, v);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void Clear()
        {
            for (int i = 0; i < _size; i++) 
            {
                dict[i] = null;

            }
            dict = new Entry<K, V>[_CAPACITY];
            _size = 0;
        }

        public bool Contains(object key)
        {
            return FindKey(key) > -1 ? true : false;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            int index = FindKey(key);
            if (_size > 0)
            {
                if(index >= -1)
                {
                    for (int i = index; i < _size - 1; i++)
                    {
                        dict[i] = dict[i + 1];
                    }
                    _size--;
                } else
                {
                    throw new KeyNotFoundException();
                }
                if(_size < dict.Length / 2)
                {
                    Entry<K, V>[] temp = new Entry<K, V>[dict.Length / 2];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = dict[i];
                    }
                    dict = temp;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

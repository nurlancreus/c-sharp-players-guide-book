using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    public class LimitedSizeList<T> : IEnumerable<T>
    {
        private List<T> _list;
        private int _maxSize;

        public LimitedSizeList(int maxSize)
        {
            if (maxSize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxSize), "Max size must be greater than 0.");
            }

            _list = new List<T>();
            _maxSize = maxSize;
        }

        public void Add(T item)
        {
            if (_list.Count >= _maxSize)
            {
                throw new InvalidOperationException($"Cannot add more items. The list is full (max size: {_maxSize}).");
            }

            _list.Add(item);
        }

        public int Count => _list.Count;

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}

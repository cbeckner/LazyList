using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// This is a great little utility class.  The best.
namespace XYZ.Utilities
{
    public class LazyList<T> : IList<T>, ICollection<T>, IEnumerable<T> where T : new()
    {
        private List<T> _list;

        public LazyList()
        {
            _list = new List<T>();
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    for (int i = ((IList<T>)_list).Count(); i <= index; i++)
                        _list.Add(new T());
                    
                    return ((IList<T>)_list)[index];
                }
                catch (Exception e)
                {
                    throw new Exception("Could not add missing instances : " + e.Message, e);
                }
            }

            set
            {
                ((IList<T>)_list)[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return ((IList<T>)_list).Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((IList<T>)_list).IsReadOnly;
            }
        }

        public void Add(T item)
        {
            ((IList<T>)_list).Add(item);
        }

        public void Clear()
        {
            ((IList<T>)_list).Clear();
        }

        public bool Contains(T item)
        {
            return ((IList<T>)_list).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((IList<T>)_list).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IList<T>)_list).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ((IList<T>)_list).IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ((IList<T>)_list).Insert(index, item);
        }

        public bool Remove(T item)
        {
            return ((IList<T>)_list).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<T>)_list).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<T>)_list).GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_GenericList
{
    [Version(2,11)]

    public class GenericList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 16;
        private T[] array;
        private int count;
        private int capacity;

        public GenericList() : this(InitialCapacity)
        {                                   
        }

        
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value <= count)
                {
                    throw new ArgumentOutOfRangeException("capacity", "capacity was less than the current size.");
                }
                this.capacity = value;
            }
        }
        public void Add(T element)
        {
            if(count == capacity)
            {
                this.Resize();
            }
            this.array[this.count] = element;
            this.count++;
        }

        public T this [int index]
        {
            get
            {
                checkIndex(index);
                return this.array[index];
            }
            set
            {
                checkIndex(index);
                this.array[index] = value;
            }

        }

        public void Clear()
        {
            this.count = 0;
            this.Capacity = InitialCapacity;
            this.array = new T[capacity];
        }

        public void Insert(int index, T item)
        {
            checkArgumentIndex(index);
            if (count == capacity)
            {
                this.Resize();
            }
            for (int i = count; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
            this.count++;
        }

        private void checkArgumentIndex(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("Index", "Index must be within the bounds of the list");
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOf(T item, int startIndex)
        {
            checkArgumentIndex(startIndex);
            for (int i = startIndex; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index", "Index was out of range. Must be non-negative and less than the size of the collection.");
            }
            for (int i = index; i < count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.array[count - 1] = default(T);
            this.count--;
        }
        private void Resize()
        {
            this.capacity *= 2;
            T[] newArray = new T[capacity];
            for (int i = 0; i < this.array.Length; i++)
			{
			    newArray[i] = this.array[i];
			}
            this.array = newArray;
        }               

        public override string ToString()
        {
            if (count == 0)
            {
                return "[]";
            }
            StringBuilder sb = new StringBuilder(count);
            sb.Append('[');
            for (int i = 0; i < count-1; i++)
            {
                sb.AppendFormat("{0}, ", array[i]);
            }
            sb.AppendFormat("{0}]",array[count - 1]);
            return sb.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.array[i];
            }            
        }
        private void checkIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the list");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string Version()
        {
            var versionNum = string.Empty;
            var type = typeof(GenericList<T>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var attr in allAttributes)
            {
                var attribute = attr as VersionAttribute;
                if (attribute != null)
                {
                    var version = attribute;
                    versionNum = string.Format("GenericList<T> version is {0}.{1}", version.Major, version.Minor);
                }
            }

            return versionNum;
        }
    }
}

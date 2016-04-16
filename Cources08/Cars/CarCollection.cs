using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources08.Cars
{
    class CarCollection<T> where T: Car
    {

        // образец - http://referencesource.microsoft.com/#mscorlib/system/collections/generic/list.cs

        private T[] items;
        private int size;
        private int capacity=4;
        const int defaultCapacity=4;


        public int Count
        {
            get
            {
                return size;
            }
        }

        public CarCollection()
        {
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (size == items.Length) EnsureCapacity(size + 1);
            items[size++] = item;
        }

        public void Clear()
        {
            if (size > 0)
            {
                Array.Clear(items, 0, size); 
                size = 0;
            }
        }

        private void EnsureCapacity(int min)
        {
            if (items.Length < min)
            {
                int newCapacity = items.Length == 0 ? defaultCapacity : items.Length * 2;
                if (newCapacity < min) newCapacity = min;

                SetCapacity(newCapacity);
            }
        }

        private void SetCapacity(int newCapacity)
        {
            if (newCapacity != items.Length)
            {
                if (newCapacity > 0)
                {
                    T[] newItems = new T[newCapacity];
                    if (size > 0)
                    {
                        Array.Copy(items, 0, newItems, 0, size);
                    }
                    items = newItems;
                    capacity = newCapacity;
                }
                else
                {
                    items = new T[0];
                    capacity = 0;
                }
            }
            
        }

        public T this[int index]
        {
            get
            {
                if ((uint)index >= (uint)size || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }

            set
            {
                if ((uint)index >= (uint)size || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                
                items[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.size; i++)
            {
                yield return this.items[i];
            }
        }

        


    }
}

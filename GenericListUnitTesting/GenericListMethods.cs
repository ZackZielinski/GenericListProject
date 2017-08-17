using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListUnitTesting
{
    class GenericListMethods<T>
    {
        T[] itemArray = new T[0];
        int size = 0;
        int capacity = 0;
        int counter = 0;

        public void Count()
        {
            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;

            }

            for (int x = 0; x < Convert.ToInt32(itemArray[capacity]); x++)
                if (itemArray[x] != null)
                {
                    counter++;
                }

            size++;
        }

        public void Add(T item)
        {

            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;
            }

            for (int i = size; i < Convert.ToInt32(itemArray[capacity]); i++)
            {
                if (itemArray[i] == null)
                {
                    itemArray[i] = item;
                }
            }
            size++;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return itemArray[index];
            }
            set
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                itemArray[index] = value;
            }
        }



        public void Remove(T item)
        {

            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;
            }

            for (int i = size; i < Convert.ToInt32(itemArray[capacity]); i++)
            {
                if (itemArray[i] == item)
                {
                    itemArray[i]
                }
            }
            size++;
        }
    }
}

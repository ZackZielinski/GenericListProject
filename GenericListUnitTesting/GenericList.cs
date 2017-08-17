using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListUnitTesting
{
    public class GenericList<T>
    {
        T[] itemArray = new T[0];
        int size = 0;
        int capacity = 0;
        int counter;
        
        public int Count
        {
            get { return counter = Increment(); }
            set  { counter = value; }
        }

        private int Increment()
        {
            int countedValues = 0;
            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;
                itemArray = new T[capacity];
            }
            if (size == 0) {
                for (int x = countedValues; x < capacity - 1; x++)
                {
                    if (itemArray[x] == null)
                    {
                        countedValues++;
                    }
                }
            }
            else {
                for (int x = countedValues; x < capacity - 1; x++) {
                    if (itemArray[x] != null)
                    {
                        countedValues++;
                    }
                }
            }
           return countedValues;
        }

        public void Add(T value)
        {

            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;
                itemArray = new T[capacity];
            }


            for (int i = size; i < capacity; i++)
            {
                if (itemArray[i] != null)
                {
                    itemArray[i] = value;
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


        /*
        public void Remove(T value)
        {

            for (int i = 0; i < Convert.ToInt32(itemArray[capacity]); i++)
            {
                if (itemArray[i] == value)
                {
                  
                }
            }
            size--;
         }
         */
    }
}

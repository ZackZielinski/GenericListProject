using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListUnitTesting
{
    public class GenericList<T>
    {
        private T[] itemArray;
        private int size;
        private int capacity;
        private int counter;
        private bool IsFirstArray;
        private bool IsRemoveUsed;
        private int numbersRemoved;
        private string StringResult;

        public GenericList()
        {
            itemArray = new T[0];
            size = 0;
            capacity = 0;
            IsFirstArray = true;
            IsRemoveUsed = false;
            numbersRemoved = 0;
        }
        public T this[int i]
        {
            get { return itemArray[i]; }
            set { itemArray[i] = value; }
        }


        public int Count
        {
            get { return counter = Increment(); }
            set  { counter = value; }
        }

        private int Increment()
        {
            int countedValues = 0;
            
            if (size != 0) {
                for (int x = countedValues; x < size; x++)
                {
                    if (itemArray[x] != null)
                    {
                        countedValues++;
                    }
                }
            }
            else {
                countedValues = 0;
            }
            for (int x = 0; x < numbersRemoved; x++)
            {
                if (IsRemoveUsed == true)
                {
                    countedValues--;
                }
            }
           return countedValues;
        }

        public void Add(T value)
        {

            if (size == capacity)
            {
                capacity = capacity == 0 ? 4 : capacity * 2;
                T[] tempArray = new T[capacity];

                if (IsFirstArray == true)
                {
                    itemArray = tempArray;
                    IsFirstArray = false;
                }
                else
                {
                    for (int x = 0; x < size; x++)
                    {
                        tempArray[x] = itemArray[x];
                    }

                    itemArray = tempArray;
                }
            }


            for (int i = size; i < capacity; i++)
            {
                if (i > size)
                {
                    itemArray[i] = default(T);
                }
                else
                {
                    if (itemArray[i] != null)
                    {
                        itemArray[i] = value;
                    }
                }
                
            }
            size++;

        }

        
        public void Remove(T value)
        {
           for (int i = 0; i < capacity; i++)
            {
                
                if (itemArray[i].Equals(value))
                {
                    numbersRemoved++;
                    itemArray[i] = itemArray[i + 1];

                    for (int j = i; j < size+1; j++)
                    {
                        if (j == size)
                        {
                            itemArray[j] = default(T);
                        }
                        else
                        {
                            itemArray[j] = itemArray[j + 1];
                        }
                    }
                }
            }

            IsRemoveUsed = true;
        }
          
          public string AsString()
          {

            for(int x = 0; x < size; x++) {
                StringResult += string.Join("", itemArray[x]);
            }

              return StringResult;
          }

       public void Zip(GenericList<T> FirstList, GenericList<T> SecondList)
        {
            if(FirstList.capacity == 0)
            {
                FirstList.capacity = FirstList.itemArray.Count();
            }
            GenericList<T> ListResult = new GenericList<T>();
           
            for (int x = 0; x < FirstList.capacity; x++)
            {
                ListResult.Add(FirstList[x]);
                ListResult.Add(SecondList[x]);
            }

            itemArray = new T[ListResult.capacity]; 

            for(int y = 0; y < ListResult.capacity; y++)
            {
                itemArray[y] = ListResult[y];
            }
            
        }

        public static GenericList<T> operator +(GenericList<T> FirstList, GenericList<T> SecondList)
        {

        }

    }
}

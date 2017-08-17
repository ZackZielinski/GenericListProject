using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListUnitTesting
{
    public class GenericSwap<T>
    {
        public void SwapMethod(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}

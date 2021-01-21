using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void MyAdd(T item)
        {
            T[] tempArr = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArr.Length; i++)
            {
                items[i] = tempArr[i];
            }
            items[items.Length - 1] = item;

        }
        public int Length
        {
            get { return items.Length; }
        }

    }
}

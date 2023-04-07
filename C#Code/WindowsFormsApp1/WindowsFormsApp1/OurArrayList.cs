using System;

namespace WindowsFormsApp1 
{ 
     internal class OurArrayList
    {
        private T[] items;
        private int counter;

        public OurArrayList(int capacity)
        {
            items = new T[capacity];
            counter = 0;
        }

        public void Add(T item)
        {
            if (counter == items.Length)
            {
                Resize();
            }
        }

        public T Get(int index)
        {
            if (index >= counter)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }

        public void RemoveAt(int index)
        {
            if (index >= counter)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < counter - 1; i++)
            {
                items[i] = items[i + 1];
            }

            counter--;
        }

        public int Count
        {
            get { return counter; }
            set;
        }

        private void Resize()
        {
            int newCapacity = items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(items, newArray, counter);
            items = newArray;
        }

        public void Clear()
        {
            Array.Clear(items, 0, Count);
            Count = 0;
        }

    }

}
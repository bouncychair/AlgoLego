using System;

namespace WindowsFormsApp1
{

    internal class OurArrayList
    {
        private object[] items;
        private int counter;

        public OurArrayList(int capacity)
        {
            items = new object[capacity];
            counter = 0;
        }

        public void Add(object item)
        {
            if (counter == items.Length)
            {
                Resize();
            }
        }

        public object Get(int index)
        {
            if (index >= counter)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }

        public void Remove(int index)
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
        }

        private void Resize()
        {
            int newCapacity = items.Length * 2;
            object[] newArray = new object[newCapacity];
            Array.Copy(items, newArray, counter);
            items = newArray;
        }

    }
}

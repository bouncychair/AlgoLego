using System;

namespace WindowsFormsApp1
{
    public class MyBubbleSort
    {
        public MyBubbleSort()
        {
        }

        public void BubbleSort<T>(OurArrayList list) where T : IComparable<T>
        {
            T[] array = (T[])list.ToArray(typeof(T));
            int n = array.Length

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temporary = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporary;
                    }
                }
            }

            foreach (T item in array)
            {
                list.Add(item);
            }
        }
    }
}
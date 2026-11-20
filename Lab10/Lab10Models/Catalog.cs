using System;
using System.Collections.Generic;

namespace Lab10Models
{
    public class Catalog<T> where T : IEntry
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetAt(int index)
        {
            return items[index];
        }

        public bool ContainsCode(string code)
        {
            foreach (T item in items)
            {
                if (item.Code == code)
                    return true;
            }

            return false;
        }

        public void PrintAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public bool RemoveByCode(string code)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Code == code)
                {
                    items.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}
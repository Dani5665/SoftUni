using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public void SwapItems(int firstIndex, int secondIndex)
        {
            T item = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = item;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in items)
            {
                stringBuilder.AppendLine($"{item.GetType()}: {item}");
            }
            return stringBuilder.ToString().TrimEnd();
        }

        
    }
}

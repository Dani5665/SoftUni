using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class MyTuple<T, K, F>
    {
        private T item1;
        private K item2;
        private F item3;

        public T Item1 { get => item1; set => item1 = value; }
        public K Item2 { get => item2; set => item2 = value; }
        public F Item3 { get => item3; set => item3 = value; }

        public MyTuple(T item1, K item2, F item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public string GetItems()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}

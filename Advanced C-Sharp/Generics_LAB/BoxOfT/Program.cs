using System;
using System.Collections.Generic;
using System.Threading;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Box<T>
    {
        private Stack<T> list = new Stack<T>();

        public void Add(T a)
        {
            list.Push(a);
        }
        public void Remove()
        {
            list.Pop();
        }
        public int Count => list.Count;
        
    }
        
}

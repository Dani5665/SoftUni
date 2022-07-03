﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            box.Add("pesho");
            box.Add("gosho");
            box.Remove();
        }
    }

    class Box<T>
    {
        private Stack<T> list = new Stack<T>();

        public void Add(T a)
        {
            list.Push(a);
        }
        public T Remove()
        {
            T element = list.Pop();
            return element;
        }
        public int Count => list.Count;
        
    }
        
}

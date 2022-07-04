using System;

namespace _02.GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine($"{box.PrintBoxType()}: {box.PrintBoxValue()}");
            }
        }
    }
    public class Box<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public string PrintBoxType()
        {
            return item.GetType().ToString();
        }
        public string PrintBoxValue()
        {
            return item.ToString();
        }
    }
}

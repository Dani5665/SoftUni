using System;

namespace _01.GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
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

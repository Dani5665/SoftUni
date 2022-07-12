using System;
using System.Security.Cryptography;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("0");
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.RemoveRandomElement();
            list.RemoveRandomElement();
            list.RemoveRandomElement();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

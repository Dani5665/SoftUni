using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator<string>.Create(5, "Pesho");
            int[] ints= ArrayCreator<int>.Create(5, 123);
            char[] charArr = ArrayCreator<char>.Create(5, 'a');
        }
    }
    public static class ArrayCreator<T>
        
    {
        public static T[] Create(int lenght, T item)
        {
            T[] arr = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }
}

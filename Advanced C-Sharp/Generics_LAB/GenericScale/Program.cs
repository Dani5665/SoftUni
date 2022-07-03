using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> names = new EqualityScale<string>("pesho", "pesho");
            Console.WriteLine(names.AreEqual());
        }
    }
    public class EqualityScale<T>
        where T : class
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public bool AreEqual()
        {
            return left == right;
        }
    }
}

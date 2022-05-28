using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodSupply = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orderQueue = new Queue<int>();

            foreach (int item in orders)
            {
                orderQueue.Enqueue(item);
            }

            int largestOrder = 0;

            bool ordersCompleted = true;

            while (orderQueue.Count > 0)
            {
                int currentOrder = orderQueue.Peek();
                if (foodSupply - currentOrder >= 0)
                {
                    orderQueue.Dequeue();
                    if (largestOrder < currentOrder)
                    {
                        largestOrder = currentOrder;
                    }
                    foodSupply -= currentOrder;
                }
                else
                {
                    ordersCompleted = false;
                    break;
                }
            }

            if (ordersCompleted == true)
            {
                Console.WriteLine(largestOrder);
                Console.WriteLine("Orders complete");
            }
            else
            {
                int ordersLeft = 0;
                while (orderQueue.Count > 0)
                {
                    int currOrder = orderQueue.Dequeue();
                    ordersLeft = currOrder + ordersLeft;
                }
                Console.WriteLine(largestOrder);
                Console.WriteLine($"Orders left: {ordersLeft}");
            }
        }
    }
}

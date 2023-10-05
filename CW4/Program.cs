using System;
using Queue;

namespace CW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queues f = new ArrayQueue(10);// 7,8,9
            //Queues f = new ArrayListQueue(4);// 7,8,9
            //Queues f = new LinkedListQueue();// 7,8,9
            //PriorityQueue f = new ArrayListPriorityQueue(4); // WHY DOES 9,8,7?
            PriorityQueue f = new LinkedListPriorityQueue(); // 7,8,9
            f.enqueue(7);
            f.enqueue(8);
            f.enqueue(9);
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
        }
    }
}

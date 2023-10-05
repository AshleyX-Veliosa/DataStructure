using Queues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues.Queue f = new ArrayQueue(3);
            f.enqueue(7);
            f.enqueue(8);
            f.enqueue(9);
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
        }
    }
}

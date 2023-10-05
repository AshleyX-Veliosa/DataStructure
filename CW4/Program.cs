using Queue;
using System;
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
            ArrayQueue f = new ArrayQueue(10);
            //ArrayListQueue f = new ArrayListQueue(10);
            //LinkedListQueue f = new LinkedListQueue();
            //PriorityQueue f = new PriorityQueue();
            f.enqueue(7);
            Console.WriteLine(f.peek());
            f.size();
            Console.WriteLine(f.size());
            Console.WriteLine(f.isEmtpy());
        }
    }
}

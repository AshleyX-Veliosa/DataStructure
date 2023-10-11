using System;
using Queue;
using BinaryTree;

namespace CW4
{
    internal class Program
    {
        class BMI : IComparable
        {
            private double height;//ส่วนสูง
            private double weight;//น้ำหนัก
            public BMI(double height, double weight)
            {
                this.height = height;
                this.weight = weight;
            }
            public double getBMI()
            {
                return weight / (height * height);
            }
            public int CompareTo(object obj)
            {
                BMI other = (BMI)obj;
                if (this.getBMI() < other.getBMI())
                    return -1;
                else if (this.getBMI() > other.getBMI())
                    return 1;
                else
                    return 0;
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Queues f = new ArrayQueue(10);// 7,8,9
            //Queues f = new ArrayListQueue(4);// 7,8,9
            //Queues f = new LinkedListQueue();// 7,8,9
            //PriorityQueue f = new ArrayListPriorityQueue(4); // WHY DOES 9,8,7?
            //PriorityQueue f = new LinkedListPriorityQueue(); // 7,8,9
            //BinaryHeap f = new BinaryHeap(4);
            Console.WriteLine("BinaryHeap Method");
            BinaryMinHeap f = new BinaryMinHeap(10);
            f.enqueue(9);
            f.enqueue(3);
            f.enqueue(5);
            f.enqueue(7);
            f.enqueue(8);
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());
            Console.WriteLine(f.dequeue());

            Console.WriteLine("BMI Calculator");
            BMI b1 = new BMI(1.72 ,52);
            Console.WriteLine(b1.getBMI());

            Console.WriteLine("RadixSort Method");
                // Create an array of integers to sort
                int[] arr = {10, 123, 143, 183, 14, 55};

                // Print the original array
                Console.WriteLine("Original Array:");
                PrintArray(arr);

                // Sort the array using RadixSort
                RadixSort.Sort(arr);

                // Print the sorted array
                Console.WriteLine("\nSorted Array:");
                PrintArray(arr);
        }
    }
}

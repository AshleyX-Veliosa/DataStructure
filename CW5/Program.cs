using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Queues;

    internal class ProgramRDS
    {
        class RDS
        {
            private Queue[] = { 10, 123, 143, 183, 14, 55 };
            private int[] q = Queue;

            public int getMax(int[] q, int size)
            {
                int maxq = q[0];
                int i;
                for (i = 1; i < size; i++)
                    if (q[i] > maxq)
                        maxq = q[i];
                return maxq;
            }

            public void CountSort(int[] q, int size, int exp)
            {
                int output[size];
                int i, count[10] = { 0 };

                for (i = 0; i < size; i++)
                    count[(q[i] / exp) % 10]++;

                for (i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                for (i = size - 1; i >= 0; i--)
                {
                    output[count[q[i] / exp % 10] - 1] = q[i];
                    count[(q[i] / exp) % 10]--;
                }

                for (i = 0; i < size; i++)
                    q[i] = output[i];
            }

            public void RadixSort(int[] q, int size)
            {
                int max = getMax(q, size);
                int exp;
                for (exp = 1; max / exp > 0; exp *= 10)
                    CountSort(q, size, exp);
            }
            public void print(int[] q, int size)
            {
                int i;
                for (i = 0; i < size; i++)
                    Console.Write("%d\t", q[i]);
            }

            public int Main()
            {
                int queue[] = { 10, 123, 143, 183, 14, 55 };
                int i, size = sizeof(queue) / sizeof(queue[0]);
                Console.WriteLine("List of numbers before sort: \n");
                for (i = 0; i < 8; i++)
                    Console.WriteLine("%d\t", queue[i]);
                Console.ReadLine;

                RadixSort(queue, size);
                Console.WriteLine("\n\nList of numbers after sort: \n");
                Console.Write(queue, size);
                return 0;
                Console.ReadLine;
            }
        }
    }

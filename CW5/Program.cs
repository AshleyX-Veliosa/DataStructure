using System;
using BinaryTree;
using Queue;

namespace CW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] f = { 45, 13, 12, 16, 9, 5 };
            HuffmanTree t = HuffmanTree.encode(f);
            Console.WriteLine(t);
            for (int x = 0; x < t.toArray(2).Length; x++)
            {
                Console.WriteLine(t.toArray(2)[x]);
            }
        }
    }
}

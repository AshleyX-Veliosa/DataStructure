using BinaryTree;
using System;

namespace HuffmanTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] f = { 45, 13, 12, 16, 9, 5 }; // frequencies
            HuffmanTree t = HuffmanTree.encode(f); //Ajan Bok in slide hai pen toArray
            Console.WriteLine(t);
            for (int x = 0; x < t.toArray(2).Length; x++)
            {
                Console.WriteLine(t.toArray(2)[x]);
            }
        }
    }
}

using System;

namespace BinaryTreeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new Node<int>(1);
            root.Left = new Node<int>(2);
            root.Right = new Node<int>(3);
            root.Left.Left = new Node<int>(4);
            Console.WriteLine(root);
        }
    }
}

using DataStructures.Trees.BinaryTree;
using System;
using System.Collections.Generic;

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
            root.Left.Right = new Node<int>(5);
            root.Right.Left = new Node<int>(6);
            root.Right.Right = new Node<int>(7);
            Console.WriteLine(root);
            levelOrderTraverse<int>(root.Right);
        }
        static void levelOrderTraverse<T>(Node<T> root)
        {
            var list = new List<Node<T>>();
            if (root != null)
            {
                var q = new Queue<Node<T>>();
                q.Enqueue(root);
                while (q.Count>0)
                {
                    var temp = q.Dequeue();
                    list.Add(temp);
                    if(temp.Left!= null) q.Enqueue(temp.Left);
                    if (temp.Right != null) q.Enqueue(temp.Right);
                }
            }
            list.ForEach(e => Console.WriteLine(e));

        }
    }
}

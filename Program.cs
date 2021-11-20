using System;

namespace BinarySearchTree1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.TraverseInorder(obj1.root);
            Console.WriteLine();
            obj1.TraversePostorder(obj1.root);
            Console.WriteLine();
            obj1.TraversePreorder(obj1.root);
        }
    }
}

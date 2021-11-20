using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree1
{
    class BinaryTree
    {

        public node root = null;

        public void Insert(int i)
        {
            node newNode = new node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;//if root is null assign newNode to root
            }
            else
            {
                node current = root;
                node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = newNode;  //go left
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;  //go right
                            break;
                        }
                    }

                }
            }
        }

        public void TraverseInorder(node root)
        {
            if (root == null)
            {
                return;
            }

            TraverseInorder(root.LeftNode);
            Console.Write(root.data + " ");
            TraverseInorder(root.RightNode);

        }
        public void TraversePreorder(node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            TraversePreorder(root.LeftNode);

            TraversePreorder(root.RightNode);

        }
        public void TraversePostorder(node root)
        {
            if (root == null)
            {
                return;
            }

            TraversePostorder(root.LeftNode);

            TraversePostorder(root.RightNode);
            Console.Write(root.data + " ");
        }


    }
}

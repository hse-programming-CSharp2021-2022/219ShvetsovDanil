using System;
using System.Collections.Generic;

namespace Task_01
{
    class BinaryTree<T> 
        where T: IComparable
    {
        public BTnode<T> Root { get; private set; }
        private bool IsEmpty => Root is null;

        public void Insert(T value)
        {
            if (IsEmpty)
            {
                Root = new BTnode<T>(value);
                return;
            }
            Root.InsertValue(value);
        }

        public void Preorder(BTnode<T> root)
        {
            if (root is null)
                return;
            
            Console.WriteLine($"{root} ");
            Preorder(root.Left);
            Preorder(root.Right);
        }
        
        public void Inorder(BTnode<T> root)
        {
            if (root is null)
                return;
            
            Inorder(root.Left);
            Console.WriteLine($"{root} ");
            Inorder(root.Right);
        }
        
        public void Postorder(BTnode<T> root)
        {
            if (root is null)
                return;
            
            Postorder(root.Left);
            Postorder(root.Right);
            Console.WriteLine($"{root} ");
        }
        
        public void Cascade(BTnode<T> root)
        {
            var nodes = new Queue<BTnode<T>>();
            nodes.Enqueue(root);
            
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                if (node.Left is not null)
                {
                    nodes.Enqueue(node.Left);
                }
                if (node.Right is not null)
                {
                    nodes.Enqueue(node.Right);
                }
                Console.Write($"{node} ");
            }
            
            Console.WriteLine();
        }

        public void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("There is no tree!");
                return;
            }
            
            Inorder(Root);
        }
    }
}
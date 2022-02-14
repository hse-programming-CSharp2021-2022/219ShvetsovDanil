namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Print();
            
            for (var i = 1; i < 4; i++)
            {
                binaryTree.Insert(i);
            }
            binaryTree.Cascade(binaryTree.Root);
            
            binaryTree.Preorder(binaryTree.Root);
            binaryTree.Postorder(binaryTree.Root);
            binaryTree.Inorder(binaryTree.Root);
        }
    }
}
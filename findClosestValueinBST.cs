using System;

public class Program
{
    public static int FindClosestValueInBst(BST tree, int target)
    {

        int currentValue = tree.value;
        var currentNode = tree;
        while (currentNode != null)
        {
            if (Math.Abs(target - currentValue) > Math.Abs(target - currentNode.value))
            {
                Console.WriteLine(" first if, target -- " + target + " currentValue -- " + currentValue + " currentNode.value -- " + currentNode.value);
                currentValue = currentNode.value;
            }

            if (target > currentNode.value)
                currentNode = currentNode.right;
            else if (target < currentNode.value)
                currentNode = currentNode.left;
            else
                break;
        }
        return currentValue;
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public static void Main()
    {
        var root = new BST(10);
        root.left = new BST(5);
        root.left.left = new BST(2);
        root.left.left.left = new BST(1);
        root.left.right = new BST(5);
        root.right = new BST(15);
        root.right.left = new BST(13);
        root.right.left.right = new BST(14);
        root.right.right = new BST(22);

        Console.WriteLine("Closest node value to 12 -- " + FindClosestValueInBst(root, 12));
        Console.ReadLine();

    
   }
}

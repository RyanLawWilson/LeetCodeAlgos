using System;
using System.Collections.Generic;
using System.Text;


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public bool IsBalanced(TreeNode root)
    {
        // -1 indicates that the tree is not balanced
        return FindDeepestNode(root, -1) != -1;
    }

    // Height of root node is 0.
    private int FindDeepestNode(TreeNode node, int currentHeight)
    {
        currentHeight++;
        if (node == null) return currentHeight;

        int rightHeight = FindDeepestNode(node.right, currentHeight);
        int leftHeight = FindDeepestNode(node.left, currentHeight);
        if (rightHeight == -1 || leftHeight == -1) 
        {
            return -1;
        }
        int heightDifference = Math.Abs(rightHeight - leftHeight);
        if (heightDifference == 0 || heightDifference == 1)
        {
            return rightHeight > leftHeight ? rightHeight : leftHeight; 
        }

        return -1;
    }
}
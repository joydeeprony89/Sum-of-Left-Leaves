using System;
using System.Collections.Generic;

namespace Sum_of_Left_Leaves
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

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
  }

  public class Solution
  {
    public int SumOfLeftLeaves(TreeNode root)
    {
      int sum = 0;
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      while (q.Count > 0)
      {
        var node = q.Dequeue();
        if (node.left != null && node.left.left == null && node.left.right == null)
        {
          sum += node.left.val;
        }

        if (node.left != null)
          q.Enqueue(node.left);

        if (node.right != null)
          q.Enqueue(node.right);
      }

      return sum;
    }
  }
}

/*
 * Given the root of a Binary Search Tree and a target number k,
 * return true if there exist two elements in the BST such that their sum is equal to the given target.
 */

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    private HashSet<int> _set = new();

    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null) return false;
        if (_set.Contains(k - root.val))
            return true;
        _set.Add(root.val);
        return FindTarget(root.left, k) || FindTarget(root.right, k);
    }
}

public static class Program
{
    public static void Main()
    {
        
    }
}
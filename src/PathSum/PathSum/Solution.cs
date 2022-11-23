namespace PathSum;

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        var queue = new Queue<TreeNode>();
        var rest = new Queue<int>();
        
        queue.Enqueue(root);
        rest.Enqueue(targetSum);

        while (queue.Count > 0)
        {
            root = queue.Dequeue();
            targetSum = rest.Dequeue();

            if (root.left == null && root.right == null)
            {
                if (targetSum == root.val) return true;
            }

            if (root.left != null)
            {
                queue.Enqueue(root.left);
                rest.Enqueue(targetSum - root.val);
            }

            if (root.right != null)
            {
                queue.Enqueue(root.right);
                rest.Enqueue(targetSum - root.val);
            }
        }

        return false;
    }
}
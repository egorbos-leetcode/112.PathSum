using BinaryTree;

namespace Solution;

public static class Solution
{
    public static bool HasPathSum(TreeNode<int> root, int targetSum) {
        return root is not null && ((targetSum - root.val == 0 && root.left is null && root.right is null)
            || HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val));
    }
}

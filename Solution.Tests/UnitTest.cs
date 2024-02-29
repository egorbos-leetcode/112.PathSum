using BinaryTree;

namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.False(Solution.HasPathSum(TreeNode.BuildTree<int>([1, 2]), 1));
        Assert.True(Solution.HasPathSum(TreeNode.BuildTree<int>([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]), 22));
        Assert.False(Solution.HasPathSum(TreeNode.BuildTree<int>([1,2,3]), 5));
        Assert.False(Solution.HasPathSum(TreeNode.BuildTree<int>([]), 0));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}
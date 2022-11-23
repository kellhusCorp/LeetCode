using NUnit.Framework;

namespace PathSum.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_HasPathSum_Returns_True_When_Target_Sum_Equals_22()
    {
        var leftNode = new TreeNode(4);
        var rightNode = new TreeNode(8);

        var leftNodeChild = new TreeNode(11);

        var leftNodeChildChildren = new[] { new TreeNode(7), new TreeNode(2) };

        leftNodeChild.left = leftNodeChildChildren[0];
        leftNodeChild.right = leftNodeChildChildren[1];

        leftNode.left = leftNodeChild;

        var rootNode = new TreeNode(5, leftNode, rightNode);
        
        Assert.That(new Solution().HasPathSum(rootNode, 22));
    }
}
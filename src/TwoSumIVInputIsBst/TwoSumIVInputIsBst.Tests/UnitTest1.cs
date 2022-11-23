using NUnit.Framework;

namespace TwoSumIVInputIsBst.Tests;

public class Tests
{
    private Solution _solution;
    
    [SetUp]
    public void Setup()
    {
        _solution = new Solution();
    }

    [Test]
    public void Test1()
    {
        var rootNode = GetBst();

        var result = _solution.FindTarget(rootNode, 9);
        
        Assert.IsTrue(result);
    }

    [Test]
    public void Test2()
    {
        var rootNode = GetBst();

        var result = _solution.FindTarget(rootNode, 28);
        
        Assert.IsFalse(result);
    }

    [Test]
    public void Test3()
    {
        var rootNode = new TreeNode
        {
            val = 2,
            left = new TreeNode(1, null, null),
            right = new TreeNode(3, null, null)
        };

        var result = _solution.FindTarget(rootNode, 3);
        
        Assert.IsTrue(result);
    }

    private TreeNode GetBst()
    {
        return new TreeNode
        {
            val = 5,
            left = new TreeNode
            {
                val = 3,
                left = new TreeNode(2, null, null),
                right = new TreeNode(4, null, null)
            },
            right = new TreeNode
            {
                val = 6,
                left = new TreeNode(7, null, null)
            }
        };
    }
}
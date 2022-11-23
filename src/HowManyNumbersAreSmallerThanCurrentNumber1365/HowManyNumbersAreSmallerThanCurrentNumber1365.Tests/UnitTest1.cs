using NUnit.Framework;

namespace HowManyNumbersAreSmallerThanCurrentNumber1365.Tests;

public class Tests
{
    [Test]
    [TestCase(new[] { 8,1,2,2,3 }, new [] { 4,0,1,1,3 })]
    [TestCase(new[] {6,5,4,8}, new [] { 2,1,0,3 })]
    [TestCase(new[] {7,7,7,7}, new [] { 0,0,0,0 })]
    public void Test_SmallerNumbersThanCurrent_Returns_True(int[] nums, int[] expected)
    {
        var sol = new Solution();

        var result = sol.SmallerNumbersThanCurrent(nums);
        
        Assert.AreEqual(result, expected);
    }
}
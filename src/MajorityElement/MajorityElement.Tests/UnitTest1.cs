using NUnit.Framework;

namespace MajorityElement.Tests;

public class Tests
{
    [Test]
    [TestCase(new int[] {3, 2, 3})]
    public void Test_First(int[] nums)
    {
        Assert.That(new Solution().MajorityElement(nums), Is.EqualTo(3));
    }
}
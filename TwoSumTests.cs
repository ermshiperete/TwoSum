using NUnit.Framework;

namespace LeetCode
{
	public class TwoSumTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Example1()
		{
			var nums = new[] { 2, 7, 11, 15 };
			var target = 9;

			Assert.That(Solution.TwoSum(nums, target), Is.EqualTo(new[] { 0, 1 }));
		}
	}
}
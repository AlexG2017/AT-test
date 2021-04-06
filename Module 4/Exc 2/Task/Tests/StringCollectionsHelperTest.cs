using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task;

namespace Tests
{
	public class StringCollectionsHelperTest
	{
		private static readonly string[] TestDataSeparator = new[] {", ",};

		[TestCase("")]
		[TestCase("abc")]
		[TestCase("1, 2, 3")]
		[TestCase("a, b, c, d")]
		public void IsSortedShouldReturnTrue(string data)
		{
			string[] input = data.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(new StringCollectionsHelper().ISorted(input));
		}

		[TestCase("1, 3, 2")]
		[TestCase("a, d, c")]
		public void IsSortedShouldReturnFalse(string data)
		{
			string[] input = data.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsFalse(new StringCollectionsHelper().ISorted(input));
		}

		[Test]
		[Ignore("Uncomment when your implementation is ready for infinite input!")]
		public void IsSortedShouldReturnFalse()
		{
			Assert.IsFalse(new StringCollectionsHelper().ISorted(GenerateTestData()));
		}

		private IEnumerable<string> GenerateTestData()
		{
			for (var i = 0; i < 10000; i++)
			{
				yield return "b";
			}

			yield return "a";
			while (true)
			{
				yield return "b";
			}
		}
	}
}
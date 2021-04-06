using System;
using NUnit.Framework;
using Task;

namespace Tests
{
	public class StringCollectionsComparerTest
	{
		private static readonly string[] TestDataSeparator = new[] {", ",};

		[TestCase("1, 2, 3", "1, 2, 3")]
		[TestCase("a, b, c, d", "a, b, c, d")]
		public void IsSequentialEqualShouldReturnTrue(string first, string second)
		{
			string[] firstCollection = first.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);
			string[] secondCollection = second.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(new StringCollectionsComparer().IsSequentialEqual(firstCollection, secondCollection));
		}

		[TestCase("1, 2, 3", "a, b, c")]
		[TestCase("a, d, c, d", "a, b, c")]
		[TestCase("1, 2, 3", "1, 3, 2")]
		public void IsSequentialEqualShouldReturnFalse(string first, string second)
		{
			string[] firstCollection = first.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);
			string[] secondCollection = second.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsFalse(new StringCollectionsComparer().IsSequentialEqual(firstCollection, secondCollection));
		}


		[TestCase("1, 2, 3", "1, 2, 3")]
		[TestCase("a, d, c, d", "a, b, c, d")]
		[TestCase("1, 2, 3", "3, 2, 1")]
		[TestCase("a, b, c, d", "b, a, d, c")]
		public void IsEqualShouldReturnTrue(string first, string second)
		{
			string[] firstCollection = first.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);
			string[] secondCollection = second.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsTrue(new StringCollectionsComparer().IsEqual(firstCollection, secondCollection));
		}

		[TestCase("1, 2, 3", "a, b, c")]
		[TestCase("a, d, c, d", "a, b, c")]
		[TestCase("1, 2, 3", "1, 3, 3")]
		public void IsEqualShouldReturnFalse(string first, string second)
		{
			string[] firstCollection = first.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);
			string[] secondCollection = second.Split(TestDataSeparator, StringSplitOptions.RemoveEmptyEntries);

			Assert.IsFalse(new StringCollectionsComparer().IsEqual(firstCollection, secondCollection));
		}

	}
}
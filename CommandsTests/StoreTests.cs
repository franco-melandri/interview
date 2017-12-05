using NUnit.Framework;
using TestRefactoring;


namespace CommandsTests
{
	[TestFixture]
	public class StoreTests
	{
		private Store sut;

		[SetUp]
		public void SetUp()
		{
			sut = new Store();
		}

		[Test]
		public void ShouldGetItem()
		{
			var item = sut.GetItem("wrong");
			Assert.IsNotNull(item);
		}
	}
}

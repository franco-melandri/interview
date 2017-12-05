using System;
using NUnit.Framework;
using TestRefactoring;

namespace CommandsTests
{
	[TestFixture]
    public class CommandsTests
	{
		private Commands sut;

		[SetUp]
		public void SetUp()
		{
			sut = new Commands();
		}

		[Test]
		public void ShouldPrintRun()
		{
			sut.Do(CommandTypes.Run);			
			Assert.IsTrue(false);
		}
	}
}

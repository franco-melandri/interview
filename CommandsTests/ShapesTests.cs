using NUnit.Framework;
using TestRefactoring;

namespace CommandsTests
{
	[TestFixture]
	public class ShapesTests
	{

		[Test]
		public void ShouldCalculateRigthArea()
		{
			var shapes = new Shape[]
			{
				new Circle(1),
				new Square(1), 
			};

			Assert.AreEqual(new AreaCalculator(shapes)
				.Sum(), 4.14159298F);
		}

		[Test]
		public void ShouldShowRigthArea()
		{
			var shapes = new Shape[]
			{
				new Circle(1),
				new Square(1),
			};

			Assert.AreEqual(new AreaCalculator(shapes)
				.Show(), "<div>4,141593</div>");
		}
	}
}

using System;

namespace TestRefactoring
{
	class Program
	{
		static void Main()
		{
			var commands = new Commands();
			commands.Do(CommandTypes.Run);

			var store = new Store();
			var item = store.GetItem("code");
			if (item != null)
			{
				Console.WriteLine(item.Code);
			}

			var shapes = new Shape[]
			{
				new Circle(1),
				new Square(1),
			};
			Console.WriteLine(new AreaCalculator(shapes).Show());

			Console.ReadKey();
		}
	}
}

using System;

namespace TestRefactoring
{
	public class Item
	{
		public string Code { get; set; }
	}

	public class StoreDAO
	{
		public Item SeearchItem(string code)
		{
			if (code == "code")
				return new Item
				{
					Code = "code"
				};
			throw new Exception("item not found");
		}
	}

	public class Store
	{
		private StoreDAO db = new StoreDAO();

		public Item GetItem(string code)
		{
			try
			{
				return db.SeearchItem(code);
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}

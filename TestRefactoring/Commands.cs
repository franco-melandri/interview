using System;

namespace TestRefactoring
{
	public enum CommandTypes
	{
		Unknown,
		Start,
		Load,
		Run,
		Unload,
		Stop
	}

	public class Commands
	{
		public void Do(CommandTypes current)
		{
			switch (current)
			{
				case CommandTypes.Unknown:
					Console.WriteLine("Unknown command!");
					break;
				case CommandTypes.Start:
					Console.WriteLine("Starting...");
					break;
				case CommandTypes.Load:
					Console.WriteLine("Loading...");
					break;
				case CommandTypes.Run:
					Console.WriteLine("RUN");
					break;
				case CommandTypes.Unload:
					Console.WriteLine("Unloading...");
					break;
				case CommandTypes.Stop:
					Console.WriteLine("Stopped.");
					break;
			}
		}
	}
}

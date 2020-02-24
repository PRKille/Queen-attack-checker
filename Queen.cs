using System;

class Queen
{
	static void Main()
	{
		Console.Write("Give me the Queen's X coordinate: ");
		int qX = Int32.Parse(Console.ReadLine());
		Console.Write("Give me the Queen's Y coordinate: ");
		int qY = Int32.Parse(Console.ReadLine());
		Console.Write("Give me the Target's X coordinate: ");
		int tX = Int32.Parse(Console.ReadLine());
		Console.Write("Give me the Target's Y coordinate: ");
		int tY = Int32.Parse(Console.ReadLine());
		if (qX == tX || qY == tY || qX-qY == tX-tY || qX+qY == tX+tY)
		{
			Console.WriteLine("Can attack!");
			Console.WriteLine("Try again? Y/N");
			string playAgain = Console.ReadLine();
			if (playAgain == "Y" || playAgain == "y")
			{
				Main();
			}
		}
		else
		{
			Console.WriteLine("Cannot attack.");
			Console.WriteLine("Try again? Y/N");
			string playAgain = Console.ReadLine();
			if (playAgain == "Y" || playAgain == "y")
			{
				Main();
			}
		}
	}
}
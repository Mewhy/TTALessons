using System;
using System.Collections.Generic;

class Program{
    static void Main(){

		string[] stringA = { "headquarters", "floppy", "pictorial", "absurdly", "episode", "glittery" };
		int[] intA = { 25, 49, 293, 1402, 3, 9 };
		List<string> stringL = new List<string>();
		stringL.Add("300");
		stringL.Add("What's up");
		stringL.Add("This is It");
		stringL.Add("Can't control");
		stringL.Add("It's great!");
		stringL.Add("This is the last index");

		Console.WriteLine("....###....########..########.....###....##....##..######.");
		Console.WriteLine("...##.##...##.....##.##.....##...##.##....##..##..##....##");
		Console.WriteLine("..##...##..##.....##.##.....##..##...##....####...##......");
		Console.WriteLine(".##.....##.########..########..##.....##....##.....######.");
		Console.WriteLine(".#########.##...##...##...##...#########....##..........##");
		Console.WriteLine(".##.....##.##....##..##....##..##.....##....##....##....##");
		Console.WriteLine(".##.....##.##.....##.##.....##.##.....##....##.....######.");
		Console.WriteLine("");
		Console.WriteLine("Pick an index between 0 and 5 to display a string:");
		ReadStringA(stringA);
		Console.WriteLine("Pick an index between 0 and 5 to display an integer:");
		ReadIntA(intA);
		Console.WriteLine("Pick an index between 0 and 5 to display an string:");
		ReadStringL(stringL);
		Console.ReadLine();
	}

	static void ReadStringA(string[] useString) {
		string enterTry = Console.ReadLine();
		try{
			Console.WriteLine(useString[Int32.Parse(enterTry)]);
		}
		catch{
			Console.WriteLine("Not a valid index");
		}
	}

	static void ReadIntA(int[] useInt){
		string enterTry = Console.ReadLine();
		try{
			Console.WriteLine(useInt[Int32.Parse(enterTry)]);
		}
		catch{
			Console.WriteLine("Not a valid index");
		}
	}

	static void ReadStringL(List<string> useString){
		string enterTry = Console.ReadLine();
		try{
			Console.WriteLine(useString[Int32.Parse(enterTry)]);
		}
		catch{
			Console.WriteLine("Not a valid index");
		}
	}
}
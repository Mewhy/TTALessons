using System;
using System.Collections.Generic;

class Program{
    static void Main(){

		string[] stringA = { "headquarters", "floppy", "pictorial", "absurdly", "episode", "glittery" };
		List<string> stringL = new List<string>();
		stringL.Add("Ted");
		stringL.Add("Tom");
		stringL.Add("Kate");
		stringL.Add("Kurt");
		stringL.Add("Ken");
		stringL.Add("Cor");
		stringL.Add("Jack");
		stringL.Add("Seersh");
		stringL.Add("Ella");

		List<string> stringLThings = new List<string>();
		stringLThings.Add("ThingA");
		stringLThings.Add("ThingB");
		stringLThings.Add("ThingC");
		stringLThings.Add("ThingC");
		stringLThings.Add("ThingA");
		stringLThings.Add("ThingB");
		stringLThings.Add("ThingB");
		stringLThings.Add("ThingC");
		stringLThings.Add("ThingA");

		List<string> stringLThings2 = new List<string>();
		stringLThings2.Add("ThingA");
		stringLThings2.Add("ThingB");
		stringLThings2.Add("ThingC");
		stringLThings2.Add("ThingC");
		stringLThings2.Add("ThingA");
		stringLThings2.Add("ThingB");
		stringLThings2.Add("ThingB");
		stringLThings2.Add("ThingC");
		stringLThings2.Add("ThingA");

		//Loop that adds typed string to all memebers of an array 
		Console.WriteLine("Please enter a string of text that you would like to add to all items in the array:");
		string stringToAdd = Console.ReadLine();
		for (int i = 0; i < stringA.Length; i++) {
			stringA[i] = stringA[i] + stringToAdd;
		}
		//Loop that prints string array
		for (int j = 0; j < stringA.Length; j++){
			Console.WriteLine(stringA[j]);
		}
		//Loop that adds was infinite now has <= comparison
		for (int k = 0; /*Was k < k*/ k <= 10; k++){
			Console.WriteLine(".");
		}
		//Loop that shows single index with indicator for missing string
		Console.WriteLine("Enter a name you would like to search:");
		string searchTerm = Console.ReadLine();
		bool undefined = true;
		for(int l = 0; l < stringL.ToArray().Length; l++){
			if (stringL[l] == searchTerm){
				Console.WriteLine("Index of search term:" + l);
				undefined = false;
				l = stringL.ToArray().Length;
			}
		}
		if (undefined) {
			Console.WriteLine(searchTerm + " does not exist within this List");
		}

		//Filler Loop
		for (int m = 0;  m <= 10; m++)
		{
			Console.WriteLine(".");
		}

		//Loop that shows multitple index with indicator for missing string
		Console.WriteLine("Enter \"Thing\" followed by A, B, or C (make sure you don't add a space):");
		string searchTermMulti = Console.ReadLine();
		bool undefinedMulti = true;
		for (int n = 0; n < stringLThings.ToArray().Length; n++){
			if (stringLThings[n] == searchTermMulti){
				Console.WriteLine("Index of search term:" + n);
				undefinedMulti = false;
			}
		}
		if (undefinedMulti){
			Console.WriteLine(searchTermMulti + " does not exist within this List");
		}

		Console.WriteLine("Once again enter \"Thing\" followed by A, B, or C (make sure you don't add a space):");
		string searchTermYN = Console.ReadLine();
		bool notYet = false;
		foreach (string str in stringLThings2) {
			if (searchTermYN == str) {
				if (notYet){
					Console.WriteLine(str + " has already appeared in this list");
				}
				else {
					Console.WriteLine(str + " has not already appeared in this list");
					undefinedMulti = true;
				}
			}
		}

		Console.ReadLine();
	}
}
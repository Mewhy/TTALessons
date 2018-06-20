using System;
	
class Assign{

	static void Main(){
		//Title
		Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
		//Course Question
		Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
		//Page Number
		Console.WriteLine("What page number?");
        string pageString = Console.ReadLine();
		int pageNumber = Convert.ToInt32(pageString);
		//Help
		Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        string helpString = Console.ReadLine();
        bool helpBool = Convert.ToBoolean(helpString);
		//Positive
		Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveFeedback = Console.ReadLine();
		//Other
		Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
		string otherFeedback = Console.ReadLine();
		//Other
		Console.WriteLine("How many hours did you study today?");
		string hourString = Console.ReadLine();
		int hourNumber = Convert.ToInt32(hourString);
		Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
		Console.ReadLine();
	}
}
using System;
using System.Text;

class Strings{
    static void Main(){
        Console.WriteLine("Please enter your name:");

        string name = Console.ReadLine();
        string date = DateTime.Today.ToShortDateString();

        name = name.ToUpper();

        string firstParse = ("Welcome " + name + ", the date is " + date);

        Console.WriteLine(firstParse);

        StringBuilder sb = new StringBuilder();
        for (int count = 0; count <= 6; count++){
            if (count == 0){
                sb.Append("This is the 1st sentence a sentence.");
            }
            else{
                sb.Append("This sentence is number " + count + " of the additional sentences.");
            }
        }

        Console.WriteLine(sb);
        Console.ReadLine();
    }
}
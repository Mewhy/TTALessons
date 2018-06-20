using System;

class Program{
    static void Main(){
        Console.WriteLine("Car Insurance Assesment Program");

        //Person 1
        Console.WriteLine("What is your age?");
        string ageStr = Console.ReadLine();
        int ageInt = Convert.ToInt32(ageStr);

        Console.WriteLine("Have you ever had a DUI?");
        string DUIStr = Console.ReadLine();
        bool DUIbool;
        if (DUIStr == "no" || DUIStr == "No" || DUIStr == "false" || DUIStr == "False"){
            DUIbool = false;
        }
        else {
            DUIbool = true;
        }

        Console.WriteLine("How many speeding tickets do you have?");
        string speedStr = Console.ReadLine();
        int speedInt = Convert.ToInt32(speedStr);

        if (ageInt > 15 && !DUIbool && speedInt < 4) {
            Console.WriteLine("You qualify for car insurance!");
        }
        else{
            Console.WriteLine("You do not qualify for insurance.");
        }
        Console.ReadLine();
    }
}
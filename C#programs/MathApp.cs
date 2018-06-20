using System;

    class MathApp{
        static void Main(){
            //Multiply by 50
            Console.WriteLine("Enter a number:");
            string mltStr = Console.ReadLine();
            int mltInt = Convert.ToInt32(mltStr);
            Console.WriteLine(mltStr + " times 50 = " + (mltInt * 50));
            Console.ReadLine();

            //Add 25
            Console.WriteLine("Enter a number:");
            string addStr = Console.ReadLine();
            int addInt = Convert.ToInt32(addStr);
            Console.WriteLine(addStr + " plus 25 = " + (addInt + 25));
            Console.ReadLine();

            //Divide by 12.5
            Console.WriteLine("Enter a number:");
            string divStr = Console.ReadLine();
            int divInt = Convert.ToInt32(divStr);
            Console.WriteLine(divStr + " divided by 12.5 = " + (divInt / 12.5));
            Console.ReadLine();

            //Greater than 50
            Console.WriteLine("Enter a number:");
            string grtrStr = Console.ReadLine();
            int grtrInt = Convert.ToInt32(divStr);
            Console.WriteLine(grtrStr + " is greater than 50 = " + (grtrInt < 50));
            Console.ReadLine();

            //Remainder of division by 7
            Console.WriteLine("Enter a number:");
            string rmnStr = Console.ReadLine();
            int rmnInt = Convert.ToInt32(divStr);
            Console.WriteLine("The remainder of " + rmnStr + " devided by 7 = " + (rmnInt % 7));
            Console.ReadLine();
        }
    }
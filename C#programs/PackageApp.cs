using System;

class Program{
    static void Main(){
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


        Console.WriteLine("Please enter the package weight:");
        int pkgWeight = Convert.ToInt32(Console.ReadLine());

        if (pkgWeight < 50){
            Console.WriteLine("Please enter the package width:");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            int totalDims = pkgHeight + pkgLength + pkgWidth;

            if (totalDims < 50){
                Console.WriteLine("The total cost is $" + (totalDims * pkgWeight) / 100);
                Console.ReadLine();
            }
            else {
                Console.WriteLine( "Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
        }
        else {
            Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            Console.ReadLine();
        }
    }
}
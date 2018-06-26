using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        //Person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        string p1HourlyRateStr = Console.ReadLine();
        int p1HourlyRateInt = Convert.ToInt32(p1HourlyRateStr);
        Console.WriteLine("Hours worked per week?");
        string p1HoursWorkedStr = Console.ReadLine();
        int p1HoursWorkedInt = Convert.ToInt32(p1HoursWorkedStr);
        int p1TotalWage = p1HourlyRateInt * p1HoursWorkedInt * 52;

        //Person 2
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        string p2HourlyRateStr = Console.ReadLine();
        int p2HourlyRateInt = Convert.ToInt32(p2HourlyRateStr);
        Console.WriteLine("Hours worked per week?");
        string p2HoursWorkedStr = Console.ReadLine();
        int p2HoursWorkedInt = Convert.ToInt32(p2HoursWorkedStr);
        int p2TotalWage = p2HourlyRateInt * p2HoursWorkedInt * 52;

        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(p1TotalWage);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(p2TotalWage);
        Console.WriteLine("Does Person 1 make more money than Person 2 ?");
        Console.WriteLine(p1TotalWage > p2TotalWage);

        Console.ReadLine();
    }
}
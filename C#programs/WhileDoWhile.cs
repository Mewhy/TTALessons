using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("While and Do While");

        float intprog = 0;
        int times = 0;

        //Do while
        do
        {
            //While
            Console.WriteLine("Enter a number");
            float intly = Convert.ToInt32(Console.ReadLine());

            while (intly <= 300)
            {
                Random r = new Random();
                intly = (intly * r.Next(1, 10) / r.Next(1, 10));
                Console.WriteLine(intly);
                if (intly == 0)
                {
                    intly++;
                }
            }
            Console.WriteLine(intly);
            intprog += intly;
            times++;
        }
        while (times < 10);

        Console.WriteLine("Final number:");
        Console.WriteLine(intprog);

        Console.ReadLine();
    }
}
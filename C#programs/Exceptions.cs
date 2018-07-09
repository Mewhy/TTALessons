using System;
using System.Collections.Generic;

namespace TTAApp1{

    class Program{

        static void Main(){
			List<int> nums = new List<int>();
			nums.Add(1);
			nums.Add(34);
			nums.Add(72);
			nums.Add(46);
			nums.Add(92);
			nums.Add(15);

			try {
				Console.WriteLine("Enter a number to divide by:");
				int divNum = Int32.Parse(Console.ReadLine());
				foreach (int num in nums){
					Console.WriteLine(num / divNum);
				}
			}
			catch (DivideByZeroException ex){
				Console.WriteLine("Don't use zeros in division :");
				Console.WriteLine(ex);
			}
			catch (FormatException ex){
				Console.WriteLine("Don't use letters in division :");
				Console.WriteLine(ex);
			}
			Console.Read();
        }
    }
}
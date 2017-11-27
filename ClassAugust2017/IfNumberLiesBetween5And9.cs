using System;

namespace IfNumberLiesBetween5And9
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int inputNumber;
			Console.WriteLine("ENTER A NUMBER");
			inputNumber=Convert.ToInt32(Console.ReadLine());
			if (inputNumber>=5&&inputNumber<=9) 
			{
				Console.WriteLine(inputNumber+" lies between 5 and 9");
			}
			else
				Console.WriteLine("Dont lie between 5 and 9");
			Console.ReadKey(true);
		}
  }
}

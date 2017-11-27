using System;

namespace CheckIfNumberIsAbove40Below60
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int inputNumber;
			Console.WriteLine("ENTER A NUMBER");
			inputNumber=Convert.ToInt32(Console.ReadLine());
			if (inputNumber>40&&inputNumber<60&&inputNumber%10==0) 
			{
				Console.WriteLine(inputNumber+" Yup");
			}
			else
			{
				Console.WriteLine("failed");
			}
			Console.ReadKey(true);
		}
  }
}

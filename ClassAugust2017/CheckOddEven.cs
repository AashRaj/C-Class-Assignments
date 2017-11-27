using System;

namespace CheckOddEven
{
	class Program
	{	
		public static void Main(string[] args)
		{
			int inputNumber;
			Console.WriteLine("ENTER A NUMBER");
			inputNumber=Convert.ToInt32(Console.ReadLine());
			if (inputNumber%2!=0) 
			{
				Console.WriteLine("Its a odd number");
			}
			else
				Console.WriteLine("Its a even number");
			Console.ReadKey(true);
		}
  }
}

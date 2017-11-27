using System;

namespace DivisibleBy5And3InRange50to75
{
	class Program
	{	
		public static void Main(string[] args)
		{
			for (int i = 50; i <= 75;i++) 
			{
				if (i%5==0&&i%3==0)
				{
					Console.WriteLine(i+" Divisible by 5 and 3");
				}
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
